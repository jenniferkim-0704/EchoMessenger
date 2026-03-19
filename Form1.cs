namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnSend_Click(object sender, EventArgs e)
        {
            SendMessage();
        }

        private void SendMessage()
        {
            string typed_msg = txtMessenger.Text.Trim(); // 공백만 있는 경우 전송하지 않음
            if (string.IsNullOrEmpty(typed_msg))
            {
                txtMessenger.Focus();
                return;
            }

            // 앞뒤 공백을 제거한 typed_msg를 사용하여 리스트에 추가
            lstEchoWindow.Items.Add($"{DateTime.Now:[HH:mm:ss]} {typed_msg}"); // 입력된 메시지 앞에 현재시간을 붙여 리스트박스에 추가
            txtMessenger.Clear();
            txtMessenger.Focus();
            UpdateMessageCount();
        }

        private void UpdateMessageCount()
        {
            // lblCount는 Designer에서 선언됨
            lblCount.Text = $"총 메시지: {lstEchoWindow.Items.Count}";
        }

        // 엔터 키로 메시지 전송
        private void txtMessenger_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendMessage();
            }
        }
    }
}
