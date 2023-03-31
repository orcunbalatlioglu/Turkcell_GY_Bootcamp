namespace OpenClosedPrinciple
{
    public partial class PaymentPage : Form
    {
        OrderProcessor orderProcessor { get; set; }

        public PaymentPage(OrderProcessor _orderProcessor)
        {
            orderProcessor = _orderProcessor;
            InitializeComponent();
        }
        

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string cardName = txtCardName.Text;
            string cardNumber = txtCreditCardNumber.Text;
            int cardMonth = Convert.ToInt32(comboMonth.SelectedItem);
            int cardYear = Convert.ToInt32(comboYear.SelectedItem);
            int CV2 = Convert.ToInt32(maskedTxtCv2.Text);

            MessageBox.Show(orderProcessor.ProcessPayment(cardName, cardNumber, cardMonth, cardYear, CV2));

            if(orderProcessor.IsPaymentCompleted)
                this.Close();
        }

        private void txtCardName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
