using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SampleSynthesis
{
    public partial class MainForm : Form
    {
        private readonly SpeechSynthesizer _synth = new SpeechSynthesizer();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _synth.SetOutputToDefaultAudioDevice();

            var voices = _synth.GetInstalledVoices().Where(voice => voice.Enabled).ToList();
            cboVoice.Width = voices.Max(voice => TextRenderer.MeasureText($"{voice.VoiceInfo.Name} {voice.VoiceInfo.Culture.DisplayName}", cboVoice.Font).Width) + 30;

            var dt = new DataTable();
            dt.Columns.Add("Text", Type.GetType("System.String"));
            dt.Columns.Add("Value", Type.GetType("System.String"));

            voices.ForEach(voice =>
            {
                dt.Rows.Add($"{voice.VoiceInfo.Name} {voice.VoiceInfo.Culture.DisplayName}", voice.VoiceInfo.Name);
            });
            cboVoice.DataSource = dt;
            cboVoice.DisplayMember = "Text";
            cboVoice.ValueMember = "Value";

            var root = new TreeNode
            {
                Text = @"资源",
                Tag = Path.Combine(Directory.GetCurrentDirectory(), "Resources")
            };
            treeView1.Nodes.Add(root);
            BindChild(root);
        }

        private void BindChild(TreeNode fNode)
        {
            string path = fNode.Tag.ToString();

            //父目录
            var fDir = new DirectoryInfo(path);
            var finfos = fDir.GetFileSystemInfos();

            foreach (FileSystemInfo f in finfos)
            {
                var type = f.GetType().ToString();
                var node = new TreeNode();
                node.Text = f.Name;
                node.Tag = f.FullName;

                fNode.Nodes.Add(node);
                if ("System.IO.DirectoryInfo" == type)
                {
                    BindChild(node);
                }
            }
        }

        private static string GenerateRandomCode(int length)
        {
            var result = new StringBuilder();
            for (var i = 0; i < length; i++)
            {
                var r = new Random(Guid.NewGuid().GetHashCode());
                result.Append(r.Next(0, 10));
            }
            return result.ToString();
        }

        private void btnVoice_Click(object sender, EventArgs e)
        {
            var path = this.treeView1.SelectedNode.Tag.ToString();

            try
            {
                if (this.cboRate.SelectedIndex > -1)
                {
                    _synth.Rate = Convert.ToInt32(this.cboRate.SelectedItem);
                }
                if (this.cboVolume.SelectedIndex > -1)
                {
                    _synth.Volume = Convert.ToInt32(this.cboVolume.SelectedItem);
                }
                if (this.cboVoice.SelectedIndex > 0)
                {
                    _synth.SelectVoice(this.cboVoice.SelectedValue.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (this.chkContinuous.Checked)
            {
                _synth.SpeakCompleted += (s, arg) => this.btnVoice.Enabled = true;
                this.btnVoice.Enabled = false;
                var text = this.txtVoice.Text;

                _synth.SpeakAsync(text);
            }
            else
            {
                if (File.Exists(path))
                {
                    var lines = File.ReadAllLines(path).ToList();
                    if (this.rdoRandom.Checked)
                    {
                        lines = lines.Select(x => new KeyValuePair<string, string>(GenerateRandomCode(lines.Count), x))
                        .OrderBy(x => x.Key).Select(x => x.Value).ToList();
                    }

                    this.Invoke(new Action(() =>
                    {
                        this.txtVoice.Clear();
                    }));
                    foreach (var text in lines)
                    {
                        _synth.Speak(text.Trim());
                        this.txtVoice.AppendText($"{text}{Environment.NewLine}");
                        if (this.cboInterval.SelectedIndex > -1)
                        {
                            Thread.Sleep(Convert.ToInt32(this.cboInterval.SelectedItem) * 1000);
                        }
                    }
                }
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            _synth.Pause();
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            _synth.Resume();
        }

        private void chkContinuous_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox)
            {
                if (checkBox.Checked)
                {
                    this.rdoOrder.Enabled = false;
                    this.rdoRandom.Enabled = false;
                    this.cboInterval.Enabled = false;
                }
                else
                {
                    this.rdoOrder.Enabled = true;
                    this.rdoRandom.Enabled = true;
                    this.cboInterval.Enabled = true;
                }
            }
        }
    }
}
