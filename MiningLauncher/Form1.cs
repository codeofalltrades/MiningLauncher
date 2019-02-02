using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace MiningLauncher
{
    public partial class Form1 : Form
    {
        private AbortableBackgroundWorker backgroundWorker1 = new AbortableBackgroundWorker();
        private Process exeProcess = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                AddEvent("Starting miner process...");
                txtArguments.Text = BuildTrexCommand();
                Application.DoEvents();
                string[] colParams = new[] { txtMinerExePath.Text, BuildTrexCommand() };
                if (backgroundWorker1.IsBusy)
                {
                    backgroundWorker1.Abort();
                    backgroundWorker1.Dispose();
                    backgroundWorker1 = new AbortableBackgroundWorker();
                }
                backgroundWorker1.RunWorkerAsync(colParams);
            }
            catch(Exception ex)
            {
                AddEvent(ex.Message);
                AddEvent(ex.StackTrace.ToString());
            }           
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            AddEvent("Request to stop miner process.");

            try
            {
                exeProcess.Kill();
                if (backgroundWorker1.IsBusy)
                {
                    backgroundWorker1.Abort();
                    backgroundWorker1.Dispose();
                }
            }
            catch (Exception ex)
            {
                AddEvent(ex.Message);
                AddEvent(ex.StackTrace.ToString());
            }
            try
            {
                backgroundWorker1 = new AbortableBackgroundWorker();
            }
            catch
            {

            }
        }

        private int LaunchMiner(string minerPath, string cmdArguments)
        {       
            // Use ProcessStartInfo class.
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = false;
            startInfo.UseShellExecute = false;
            startInfo.FileName = minerPath;
            startInfo.WindowStyle = ProcessWindowStyle.Normal;
            startInfo.Arguments = cmdArguments;

            try
            {
                // Start the process with the info we specified.
                // Call WaitForExit and then the using-statement will close.                
                using (exeProcess = Process.Start(startInfo))
                {
                    exeProcess.WaitForExit();

                    //AddEvent("Miner process stopped.");
                }
            }
            catch (Exception ex)
            {
                //AddEvent(ex.StackTrace.ToString());
                return 0;
            }
            return 1;
        }

        private void AddEvent(string msg)
        {
            txtEventLog.Text = string.Format("{0}[{1}] {2}{3}", txtEventLog.Text, DateTime.Now, msg, Environment.NewLine);
            Application.DoEvents();
        }

        private void ClearEvents()
        {
            txtEventLog.Text = "";
            Application.DoEvents();
        }

        private void btnSuperDefault_Click(object sender, EventArgs e)
        {
            ctrMainPoolUrl.Text = "stratum+tcp://veil.suprnova.cc:7220";
            ctrMainPoolAlgo.Text = "x16rt";
            ctrMainPoolWorkerUsername.Text = "VielSuperMiner.mining_launcher";
            ctrMainPoolWorkerPassword.Text = "x";
        }

        private void btnVeilDefault_Click(object sender, EventArgs e)
        {
            ctrMainPoolUrl.Text = "stratum+tcp://stratum.veilmine.com:2019";
            ctrMainPoolAlgo.Text = "x16rt";
            ctrMainPoolWorkerUsername.Text = "VielSuperMiner.mining_launcher";
            ctrMainPoolWorkerPassword.Text = "x";
        }

        private void btnCoinblockersDefault_Click(object sender, EventArgs e)
        {
            ctrMainPoolUrl.Text = "stratum+tcp://veil-us.coinblockers.com:4200";
            ctrMainPoolAlgo.Text = "x16rt";
            ctrMainPoolWorkerUsername.Text = "bv1q395zw3kfgwcdu63ejle2qpe3u0z7j63xd75h4v.mining_launcher";
            ctrMainPoolWorkerPassword.Text = "x";
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker helperBW = sender as BackgroundWorker;
            string[] colParams = e.Argument as string[];
            while (!helperBW.CancellationPending)
            {
                e.Result = LaunchMiner(colParams[0], colParams[1]);
                Thread.Sleep(30000);
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //if (e.Cancelled) MessageBox.Show("Operation was canceled");
            //else if (e.Error != null) MessageBox.Show(e.Error.Message);
            //else MessageBox.Show(e.Result.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ctrDevices.Text = "0";

            backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);
        }

        private void btnCCminer_Click(object sender, EventArgs e)
        {
            txtMinerExePath.Text = @"C:\zMiners\suprminer-2.0\ccminer.exe";
            ctrIntensity.Text = "19";
        }

        private void btnTrex_Click(object sender, EventArgs e)
        {

            txtMinerExePath.Text = @"C:\zMiners\t-rex-0.9.1-win-cuda10.0\t-rex.exe";
            ctrIntensity.Text = "19";

        }

        private string BuildTrexCommand()
        {
            var oSzCmd = new StringBuilder();
            oSzCmd.AppendFormat("-a {0} -o {1} -u {2}",
                                ctrMainPoolAlgo.Text, ctrMainPoolUrl.Text, ctrMainPoolWorkerUsername.Text);

            if (!string.IsNullOrWhiteSpace(ctrDevices.Text))
            {
                oSzCmd.AppendFormat(" -d {0}", ctrDevices.Text);
            }

            if (!string.IsNullOrWhiteSpace(ctrMainPoolWorkerPassword.Text))
            {
                oSzCmd.AppendFormat(" -p {0}", ctrMainPoolWorkerPassword.Text);
            }

            if (!string.IsNullOrWhiteSpace(ctrIntensity.Text))
            {
                oSzCmd.AppendFormat(" -i {0}", ctrIntensity.Text);
            }

            if (!string.IsNullOrWhiteSpace(ctrRetries.Text))
            {
                oSzCmd.AppendFormat(" -r {0}", ctrRetries.Text);
            }

            if (!string.IsNullOrWhiteSpace(ctrRetryPause.Text))
            {
                oSzCmd.AppendFormat(" -R {0}", ctrRetryPause.Text);
            }

            if(!string.IsNullOrWhiteSpace(ctrTimeout.Text) ||
               !string.IsNullOrWhiteSpace(ctrTimeLimit.Text) ||
               !string.IsNullOrWhiteSpace(ctrTempColor.Text) ||
               !string.IsNullOrWhiteSpace(ctrMaxTemp.Text) ||
               !string.IsNullOrWhiteSpace(ctrRestartTemp.Text))
            {
                var colParams = new List<string>();
                colParams.Add(!string.IsNullOrWhiteSpace(ctrTimeout.Text) ? ctrTimeout.Text : "180");
                colParams.Add(!string.IsNullOrWhiteSpace(ctrTimeLimit.Text) ? ctrTimeLimit.Text : "0");
                colParams.Add(!string.IsNullOrWhiteSpace(ctrTempColor.Text) ? ctrTempColor.Text : "67,77");
                colParams.Add(!string.IsNullOrWhiteSpace(ctrMaxTemp.Text) ? ctrMaxTemp.Text : "0");
                colParams.Add(!string.IsNullOrWhiteSpace(ctrRestartTemp.Text) ? ctrRestartTemp.Text : "0");

                oSzCmd.AppendFormat(" -T {0}", @"""" + string.Join(" ", colParams) + @"""");
            }           

            return oSzCmd.ToString();
        }
        
        private string BuildCCMinerCommand()
        {
            var oSzCmd = new StringBuilder();
            oSzCmd.AppendFormat("-a {0} -o {1} -u {2}",
                                ctrMainPoolAlgo.Text, ctrMainPoolUrl.Text, ctrMainPoolWorkerUsername.Text);

            if (!string.IsNullOrWhiteSpace(ctrDevices.Text))
            {
                oSzCmd.AppendFormat(" -d {0}", ctrDevices.Text);
            }

            if (!string.IsNullOrWhiteSpace(ctrMainPoolWorkerPassword.Text))
            {
                oSzCmd.AppendFormat(" -p {0}", ctrMainPoolWorkerPassword.Text);
            }

            if (!string.IsNullOrWhiteSpace(ctrIntensity.Text))
            {
                oSzCmd.AppendFormat(" -i {0}", ctrIntensity.Text);
            }
            return oSzCmd.ToString();
        }

        private void ctrMaxTemp_TextChanged(object sender, EventArgs e)
        {

        }

        private void ctrMainPoolAlgo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
