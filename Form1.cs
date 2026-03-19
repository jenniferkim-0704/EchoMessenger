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
            string typed_msg = txtMessenger.Text; // txtMessenger 텍스트박스에 입력된 문자열을 가져와서 typed_msg 변수에 저장
            lstEchoWindow.Items.Add(typed_msg); // lstEchoWindow 리스트박스에 typed_msg 변수를 추가하여 메시지를 표시
            txtMessenger.Clear(); // txtMessenger 텍스트박스의 내용을 지워서 다음 메시지를 입력할 수 있도록 준비
        }
    }
}
