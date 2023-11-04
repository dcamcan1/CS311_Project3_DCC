namespace CS311_Project3_DCC
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            lblRestaurantName = new Label();
            cboSize = new ComboBox();
            lblSize = new Label();
            grpCrustType = new GroupBox();
            rdoRegular = new RadioButton();
            rdoThick = new RadioButton();
            rdoThin = new RadioButton();
            grpToppings = new GroupBox();
            ckbExtraCheese = new CheckBox();
            ckbMushroom = new CheckBox();
            ckbJalapeño = new CheckBox();
            ckbBananaPeppers = new CheckBox();
            ckbBlackOlives = new CheckBox();
            ckbGreenOlives = new CheckBox();
            ckbGreenPepper = new CheckBox();
            ckbOnion = new CheckBox();
            ckbCanadianBacon = new CheckBox();
            ckbItalianSausage = new CheckBox();
            ckbSausage = new CheckBox();
            ckbPepperoni = new CheckBox();
            lblOrderSummary = new Label();
            rtfOrderSummary = new RichTextBox();
            lblSubTotal = new Label();
            lblTax = new Label();
            lblTotal = new Label();
            txtSubTotal = new TextBox();
            txtTax = new TextBox();
            txtTotal = new TextBox();
            btnCalculate = new Button();
            btnClear = new Button();
            imageList1 = new ImageList(components);
            pictPizzaSlice = new PictureBox();
            grpCrustType.SuspendLayout();
            grpToppings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictPizzaSlice).BeginInit();
            SuspendLayout();
            // 
            // lblRestaurantName
            // 
            lblRestaurantName.AutoSize = true;
            lblRestaurantName.Font = new Font("Chiller", 65.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblRestaurantName.Image = (Image)resources.GetObject("lblRestaurantName.Image");
            lblRestaurantName.Location = new Point(40, 52);
            lblRestaurantName.Name = "lblRestaurantName";
            lblRestaurantName.Size = new Size(467, 101);
            lblRestaurantName.TabIndex = 0;
            lblRestaurantName.Text = "Slice Slice Baby";
            // 
            // cboSize
            // 
            cboSize.FormattingEnabled = true;
            cboSize.Items.AddRange(new object[] { "Small", "Medium", "Large", "X-Large", "Ginormous" });
            cboSize.Location = new Point(146, 191);
            cboSize.Name = "cboSize";
            cboSize.Size = new Size(152, 23);
            cboSize.TabIndex = 2;
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.BackColor = Color.Transparent;
            lblSize.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblSize.ImageAlign = ContentAlignment.TopLeft;
            lblSize.Location = new Point(85, 191);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(40, 20);
            lblSize.TabIndex = 3;
            lblSize.Text = "Size:";
            // 
            // grpCrustType
            // 
            grpCrustType.BackColor = Color.Transparent;
            grpCrustType.Controls.Add(rdoRegular);
            grpCrustType.Controls.Add(rdoThick);
            grpCrustType.Controls.Add(rdoThin);
            grpCrustType.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            grpCrustType.Location = new Point(339, 189);
            grpCrustType.Name = "grpCrustType";
            grpCrustType.Size = new Size(382, 33);
            grpCrustType.TabIndex = 5;
            grpCrustType.TabStop = false;
            grpCrustType.Text = "Crust Type:";
            // 
            // rdoRegular
            // 
            rdoRegular.AutoSize = true;
            rdoRegular.Location = new Point(277, -2);
            rdoRegular.Name = "rdoRegular";
            rdoRegular.Size = new Size(81, 24);
            rdoRegular.TabIndex = 2;
            rdoRegular.TabStop = true;
            rdoRegular.Text = "Regular";
            rdoRegular.UseVisualStyleBackColor = true;
            // 
            // rdoThick
            // 
            rdoThick.AutoSize = true;
            rdoThick.Location = new Point(196, -2);
            rdoThick.Name = "rdoThick";
            rdoThick.Size = new Size(64, 24);
            rdoThick.TabIndex = 1;
            rdoThick.TabStop = true;
            rdoThick.Text = "Thick";
            rdoThick.UseVisualStyleBackColor = true;
            // 
            // rdoThin
            // 
            rdoThin.AutoSize = true;
            rdoThin.Location = new Point(118, -2);
            rdoThin.Name = "rdoThin";
            rdoThin.Size = new Size(58, 24);
            rdoThin.TabIndex = 0;
            rdoThin.TabStop = true;
            rdoThin.Text = "Thin";
            rdoThin.UseVisualStyleBackColor = true;
            // 
            // grpToppings
            // 
            grpToppings.BackColor = Color.Transparent;
            grpToppings.Controls.Add(ckbExtraCheese);
            grpToppings.Controls.Add(ckbMushroom);
            grpToppings.Controls.Add(ckbJalapeño);
            grpToppings.Controls.Add(ckbBananaPeppers);
            grpToppings.Controls.Add(ckbBlackOlives);
            grpToppings.Controls.Add(ckbGreenOlives);
            grpToppings.Controls.Add(ckbGreenPepper);
            grpToppings.Controls.Add(ckbOnion);
            grpToppings.Controls.Add(ckbCanadianBacon);
            grpToppings.Controls.Add(ckbItalianSausage);
            grpToppings.Controls.Add(ckbSausage);
            grpToppings.Controls.Add(ckbPepperoni);
            grpToppings.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            grpToppings.Location = new Point(85, 230);
            grpToppings.Name = "grpToppings";
            grpToppings.Size = new Size(636, 149);
            grpToppings.TabIndex = 6;
            grpToppings.TabStop = false;
            grpToppings.Text = "Toppings:";
            // 
            // ckbExtraCheese
            // 
            ckbExtraCheese.AutoSize = true;
            ckbExtraCheese.Location = new Point(452, 89);
            ckbExtraCheese.Name = "ckbExtraCheese";
            ckbExtraCheese.Size = new Size(117, 24);
            ckbExtraCheese.TabIndex = 11;
            ckbExtraCheese.Text = "Extra Cheese";
            ckbExtraCheese.UseVisualStyleBackColor = true;
            // 
            // ckbMushroom
            // 
            ckbMushroom.AutoSize = true;
            ckbMushroom.Location = new Point(452, 119);
            ckbMushroom.Name = "ckbMushroom";
            ckbMushroom.Size = new Size(105, 24);
            ckbMushroom.TabIndex = 10;
            ckbMushroom.Text = "Mushroom";
            ckbMushroom.UseVisualStyleBackColor = true;
            // 
            // ckbJalapeño
            // 
            ckbJalapeño.AutoSize = true;
            ckbJalapeño.Location = new Point(452, 59);
            ckbJalapeño.Name = "ckbJalapeño";
            ckbJalapeño.Size = new Size(90, 24);
            ckbJalapeño.TabIndex = 9;
            ckbJalapeño.Text = "Jalapeño";
            ckbJalapeño.UseVisualStyleBackColor = true;
            // 
            // ckbBananaPeppers
            // 
            ckbBananaPeppers.AutoSize = true;
            ckbBananaPeppers.Location = new Point(452, 29);
            ckbBananaPeppers.Name = "ckbBananaPeppers";
            ckbBananaPeppers.Size = new Size(140, 24);
            ckbBananaPeppers.TabIndex = 8;
            ckbBananaPeppers.Text = "Banana Peppers";
            ckbBananaPeppers.UseVisualStyleBackColor = true;
            // 
            // ckbBlackOlives
            // 
            ckbBlackOlives.AutoSize = true;
            ckbBlackOlives.Location = new Point(258, 89);
            ckbBlackOlives.Name = "ckbBlackOlives";
            ckbBlackOlives.Size = new Size(111, 24);
            ckbBlackOlives.TabIndex = 7;
            ckbBlackOlives.Text = "Black Olives";
            ckbBlackOlives.UseVisualStyleBackColor = true;
            // 
            // ckbGreenOlives
            // 
            ckbGreenOlives.AutoSize = true;
            ckbGreenOlives.Location = new Point(258, 119);
            ckbGreenOlives.Name = "ckbGreenOlives";
            ckbGreenOlives.Size = new Size(116, 24);
            ckbGreenOlives.TabIndex = 6;
            ckbGreenOlives.Text = "Green Olives";
            ckbGreenOlives.UseVisualStyleBackColor = true;
            // 
            // ckbGreenPepper
            // 
            ckbGreenPepper.AutoSize = true;
            ckbGreenPepper.Location = new Point(258, 59);
            ckbGreenPepper.Name = "ckbGreenPepper";
            ckbGreenPepper.Size = new Size(123, 24);
            ckbGreenPepper.TabIndex = 5;
            ckbGreenPepper.Text = "Green Pepper";
            ckbGreenPepper.UseVisualStyleBackColor = true;
            // 
            // ckbOnion
            // 
            ckbOnion.AutoSize = true;
            ckbOnion.Location = new Point(258, 29);
            ckbOnion.Name = "ckbOnion";
            ckbOnion.Size = new Size(70, 24);
            ckbOnion.TabIndex = 4;
            ckbOnion.Text = "Onion";
            ckbOnion.UseVisualStyleBackColor = true;
            // 
            // ckbCanadianBacon
            // 
            ckbCanadianBacon.AutoSize = true;
            ckbCanadianBacon.Location = new Point(45, 89);
            ckbCanadianBacon.Name = "ckbCanadianBacon";
            ckbCanadianBacon.Size = new Size(139, 24);
            ckbCanadianBacon.TabIndex = 3;
            ckbCanadianBacon.Text = "Canadian Bacon";
            ckbCanadianBacon.UseVisualStyleBackColor = true;
            // 
            // ckbItalianSausage
            // 
            ckbItalianSausage.AutoSize = true;
            ckbItalianSausage.Location = new Point(45, 119);
            ckbItalianSausage.Name = "ckbItalianSausage";
            ckbItalianSausage.Size = new Size(173, 24);
            ckbItalianSausage.TabIndex = 2;
            ckbItalianSausage.Text = "Spicy Italian Sausage";
            ckbItalianSausage.UseVisualStyleBackColor = true;
            // 
            // ckbSausage
            // 
            ckbSausage.AutoSize = true;
            ckbSausage.Location = new Point(45, 59);
            ckbSausage.Name = "ckbSausage";
            ckbSausage.Size = new Size(85, 24);
            ckbSausage.TabIndex = 1;
            ckbSausage.Text = "Sausage";
            ckbSausage.UseVisualStyleBackColor = true;
            // 
            // ckbPepperoni
            // 
            ckbPepperoni.AutoSize = true;
            ckbPepperoni.Location = new Point(45, 29);
            ckbPepperoni.Name = "ckbPepperoni";
            ckbPepperoni.Size = new Size(99, 24);
            ckbPepperoni.TabIndex = 0;
            ckbPepperoni.Text = "Pepperoni";
            ckbPepperoni.UseVisualStyleBackColor = true;
            // 
            // lblOrderSummary
            // 
            lblOrderSummary.AutoSize = true;
            lblOrderSummary.BackColor = Color.Transparent;
            lblOrderSummary.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblOrderSummary.Location = new Point(57, 392);
            lblOrderSummary.Name = "lblOrderSummary";
            lblOrderSummary.Size = new Size(125, 20);
            lblOrderSummary.TabIndex = 7;
            lblOrderSummary.Text = "Order Summary:";
            // 
            // rtfOrderSummary
            // 
            rtfOrderSummary.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rtfOrderSummary.Location = new Point(61, 415);
            rtfOrderSummary.Name = "rtfOrderSummary";
            rtfOrderSummary.Size = new Size(465, 207);
            rtfOrderSummary.TabIndex = 8;
            rtfOrderSummary.Text = "";
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.BackColor = Color.Transparent;
            lblSubTotal.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblSubTotal.Location = new Point(550, 417);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(74, 20);
            lblSubTotal.TabIndex = 9;
            lblSubTotal.Text = "SubTotal:";
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.BackColor = Color.Transparent;
            lblTax.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTax.Location = new Point(587, 450);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(37, 20);
            lblTax.TabIndex = 10;
            lblTax.Text = "Tax:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.Transparent;
            lblTotal.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.Location = new Point(576, 483);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(48, 20);
            lblTotal.TabIndex = 11;
            lblTotal.Text = "Total:";
            // 
            // txtSubTotal
            // 
            txtSubTotal.Location = new Point(630, 414);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.Size = new Size(142, 23);
            txtSubTotal.TabIndex = 12;
            // 
            // txtTax
            // 
            txtTax.Location = new Point(630, 447);
            txtTax.Name = "txtTax";
            txtTax.Size = new Size(142, 23);
            txtTax.TabIndex = 13;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(630, 480);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(142, 23);
            txtTotal.TabIndex = 14;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = SystemColors.GradientInactiveCaption;
            btnCalculate.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalculate.Location = new Point(550, 520);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(222, 72);
            btnCalculate.TabIndex = 15;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ControlLight;
            btnClear.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(618, 599);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 28);
            btnClear.TabIndex = 16;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // pictPizzaSlice
            // 
            pictPizzaSlice.Image = (Image)resources.GetObject("pictPizzaSlice.Image");
            pictPizzaSlice.Location = new Point(513, 12);
            pictPizzaSlice.Name = "pictPizzaSlice";
            pictPizzaSlice.Size = new Size(269, 154);
            pictPizzaSlice.SizeMode = PictureBoxSizeMode.StretchImage;
            pictPizzaSlice.TabIndex = 17;
            pictPizzaSlice.TabStop = false;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(827, 639);
            Controls.Add(pictPizzaSlice);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(txtTotal);
            Controls.Add(txtTax);
            Controls.Add(txtSubTotal);
            Controls.Add(lblTotal);
            Controls.Add(lblTax);
            Controls.Add(lblSubTotal);
            Controls.Add(rtfOrderSummary);
            Controls.Add(lblOrderSummary);
            Controls.Add(grpToppings);
            Controls.Add(grpCrustType);
            Controls.Add(lblSize);
            Controls.Add(cboSize);
            Controls.Add(lblRestaurantName);
            Name = "frmMain";
            Text = "Slice Slice Baby                                                                                                                      ";
            grpCrustType.ResumeLayout(false);
            grpCrustType.PerformLayout();
            grpToppings.ResumeLayout(false);
            grpToppings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictPizzaSlice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRestaurantName;
        private ComboBox cboSize;
        private Label lblSize;
        private GroupBox grpCrustType;
        private RadioButton rdoRegular;
        private RadioButton rdoThick;
        private RadioButton rdoThin;
        private GroupBox grpToppings;
        private CheckBox ckbCanadianBacon;
        private CheckBox ckbItalianSausage;
        private CheckBox ckbSausage;
        private CheckBox ckbPepperoni;
        private CheckBox ckbExtraCheese;
        private CheckBox ckbMushroom;
        private CheckBox ckbJalapeño;
        private CheckBox ckbBananaPeppers;
        private CheckBox ckbBlackOlives;
        private CheckBox ckbGreenOlives;
        private CheckBox ckbGreenPepper;
        private CheckBox ckbOnion;
        private Label lblOrderSummary;
        private RichTextBox rtfOrderSummary;
        private Label lblSubTotal;
        private Label lblTax;
        private Label lblTotal;
        private TextBox txtSubTotal;
        private TextBox txtTax;
        private TextBox txtTotal;
        private Button btnCalculate;
        private Button btnClear;
        private ImageList imageList1;
        private PictureBox pictPizzaSlice;
    }
}