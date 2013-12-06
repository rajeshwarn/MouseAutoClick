using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MouseKeyboardActivityMonitor;

#region -   文   件   说   明  -
//
//      创 建 人：何 苦
//      创建时间：2013/05/04 15:31:48
//      功    能：鼠标自动点击 小工具
//      个人网站：http://iheku.com
//
#endregion

namespace MouseAutoClick
{
    public partial class Form1 : Form
    {
        readonly KeyboardHookListener khl;
        readonly MouseHookListener mhl;

        public Form1()
        {
            InitializeComponent();

            //设置鼠标勾子
            mhl = new MouseHookListener(new MouseKeyboardActivityMonitor.WinApi.GlobalHooker());
            mhl.MouseMove += new MouseEventHandler(mhl_MouseMove);
            mhl.Enabled = true;

            //设置键盘勾子
            khl = new KeyboardHookListener(new MouseKeyboardActivityMonitor.WinApi.GlobalHooker());
            khl.KeyDown += new KeyEventHandler(khl_KeyDown);
            khl.Enabled = true;
        }

        //界面上实时显示鼠标坐标
        void mhl_MouseMove(object sender, MouseEventArgs e)
        {
            txtX.Text = e.X.ToString();
            txtY.Text = e.Y.ToString();
        }

        //判断按键
        void khl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F7)       //F7 设置坐标点
            {
                string action = string.Empty;

                if (rbtnLeftClick.Checked) action = rbtnLeftClick.Text;         //左单击
                else if (rbtnLeftDoubleClick.Checked) action = rbtnLeftDoubleClick.Text;   //左双击
                else if (rbtnRightClick.Checked) action = rbtnRightClick.Text;        //右单击
                else if (rbtnRightDoubleClick.Checked) action = rbtnRightDoubleClick.Text;  //右双击

                listBox1.Items.Add(string.Format("{0}|{1}|{2}|{3}", txtX.Text, txtY.Text, action, txtSleep.Text.Trim()));
            }
            else if (e.KeyCode == Keys.F8)  //F8 开始
            {
                if (listBox1.Items.Count == 0) return;

                AutoClickThread.PositionData = listBox1.Items.Cast<string>().ToList();
                AutoClickThread.Start(IsRecycleRun.Checked);
            }
            else if (e.KeyCode == Keys.F9)  //F9 停止
            {
                AutoClickThread.Stop();
            }
        }

        //删除坐标点
        private void listBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (listBox1.SelectedIndex >= 0 && e.KeyCode == Keys.Delete)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            if (e.Modifiers.CompareTo(Keys.Control) == 0 && e.KeyCode == Keys.S)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.AddExtension = true;
                sfd.Filter = "文本文件(*.txt)|*.txt";
                sfd.DefaultExt = "txt";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    FileHelper.WriteAllText(sfd.FileName, listBox1.Items.Cast<string>().ToList<string>());
                }
            }
        }

        //从文件导入
        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "文本文件(*.txt)|*.txt";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                List<string> fileContent = FileHelper.ReadAllText(ofd.FileName);
                listBox1.Items.AddRange(fileContent.ToArray<string>());
            }
        }

        //重置坐标点
        private void lblReset_Click(object sender, System.EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
