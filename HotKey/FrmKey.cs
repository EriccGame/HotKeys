using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace HotKey
{
    public partial class FrmKey : Form
    {
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        
        //public const int NOMOD = 0x0000;            //  No HotKey
        //public const int ALT = 0x0001;              //  ALT
        //public const int CTRL = 0x0002;             //  CTRL
        //public const int SHIFT = 0x0004;            //  SHIFT
        //public const int WIN = 0x0008;              //  WIN button
        //public const int WM_HOTKEY_MSG_ID = 0x0312; //  Windows message ID for HotKey

        private int iId = -1;
        private Message msgHotKey;

        public Message MsgHotKey
        {
            get { return msgHotKey; }
            set { msgHotKey = value; }
        }

        public enum Hotkeys 
        {
            NOMOD = 0x0000, 
            ALT = 0x0001,
            CTRL = 0x0002,
            SHIFT = 0x0004,
            WIN = 0x0008,
            CtrlAndShift = 0x0002 + 0x0004,
            WM_HOTKEY_MSG_ID = 0x0312
        };

        public FrmKey()
        {
            InitializeComponent();
        }

        private void FrmKey_Load(object sender, EventArgs e)
        {
            RegisterHotKey(Hotkeys.CtrlAndShift, Keys.A);
            RegisterHotKey(Hotkeys.CTRL, Keys.B);
            RegisterHotKey(Hotkeys.SHIFT, Keys.C);
            RegisterHotKey(Hotkeys.ALT, Keys.D);
            RegisterHotKey(Hotkeys.NOMOD, Keys.E);
        }

        private void FrmKey_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int i = 0; i < iId; i++)
                UnregisterHotKey(this.Handle, i);
            Application.Exit();
        }

        protected override void WndProc(ref Message m)
        {
            msgHotKey = m;

            Int32 iHotKey = (int)Hotkeys.WM_HOTKEY_MSG_ID;
            Int32 iParam = (int)msgHotKey.WParam;

            if (msgHotKey.Msg == iHotKey)
            {
                if (iParam == 0)
                    MessageBox.Show("Se ha pulsado la combinación de teclas Control + Shift + A");
                else if (iParam == 1)
                    MessageBox.Show("Se ha pulsado la combinación de teclas Control + B");
                else if (iParam == 2)
                    MessageBox.Show("Se ha pulsado la combinación de teclas Shift + C");
                else if (iParam == 3)
                    MessageBox.Show("Se ha pulsado la combinación de teclas Alt + D");
                else if (iParam == 4)
                    MessageBox.Show("Se ha pulsado la tecla E");
            }
            base.WndProc(ref m);
        }

        public void RegisterHotKey(Hotkeys hotkeys, Keys keys)
        {
            RegisterHotKey(this.Handle, iId += 1, (int)hotkeys, (int)keys);
        }

        private void tbKeyCopy_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
