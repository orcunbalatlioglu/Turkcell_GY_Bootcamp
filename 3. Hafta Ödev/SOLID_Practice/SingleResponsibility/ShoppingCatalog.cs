namespace SingleResponsibility
{
    public partial class ShoppingCatalog : Form
    {
        List<Item>? Cart { get; set;}
        OrderProcessor orderProcessor { get; set; }

        public ShoppingCatalog()
        {
            InitializeComponent();
        }

        private void btnItem1_Click(object sender, EventArgs e)
        {
            txtName.Text = "Muz";
            txtPrice.Text = "25";
            numericAmount.Value = 1;
        }

        private void btnItem2_Click_1(object sender, EventArgs e)
        {
            txtName.Text = "Erik";
            txtPrice.Text = "50";
            numericAmount.Value = 1;
        }

        private void btnItem3_Click_1(object sender, EventArgs e)
        {
            txtName.Text = "Portakal";
            txtPrice.Text = "15";
            numericAmount.Value = 1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsItemSelected()) { 
                Item item = new Item();
                item.Name = txtName.Text;
                item.Price = Convert.ToInt32(txtPrice.Text);
                item.Amount = Convert.ToInt32(numericAmount.Value);
                if(IsCartNull())
                {
                    Cart = new List<Item>();
                }
                Cart.Add(item);
            }
            else
            {
                MessageBox.Show("Herhangi bir ürün seçmediniz!");
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (!IsCartNull() && !IsCartEmpty())
            {
                Order order = new Order(Cart);
                orderProcessor = new OrderProcessor(order);
                string validationMessage = orderProcessor.ValidateOrder();
                MessageBox.Show(validationMessage);
                if (orderProcessor.IsOrderValid)
                {
                    PaymentPage paymentPage = new PaymentPage(orderProcessor);
                    paymentPage.ShowDialog();
                }

                if (orderProcessor.IsPaymentCompleted)
                {
                    if(orderProcessor.Email != null) { 
                        MessageBox.Show(orderProcessor.SendEmail());
                    }
                    else
                    {
                        MessageBox.Show(orderProcessor.SendEmail("abcdef@outlook.com"));
                    }
                    Cart.Clear();
                    MessageBox.Show("Sepetiniz boþaltýlmýþtýr!");
                }
                else
                {
                    MessageBox.Show("Ödemeniz tamamlanmadýðý için sepet boþaltýlmamýþtýr!");
                }
            }
            else
            {
                MessageBox.Show("Sepetiniz boþ olduðu için iþleminiz tamamlanamamýþtýr!");
            }
            ClearForm();
        }

        private void ClearForm()
        {
            txtName.Text = "";
            txtPrice.Text = "";
            numericAmount.Value = 0;
        }
        private bool IsItemSelected() => txtPrice.Text != "" && txtName.Text != "" && numericAmount.Value != 0;

        private bool IsCartNull() => Cart is null;

        private bool IsCartEmpty() => Cart.Count == 0;
    }
}