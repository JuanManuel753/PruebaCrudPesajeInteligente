namespace CrudPrueba
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges10 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges11 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges12 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.BtnEliminar1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.TxtBuscador = new System.Windows.Forms.TextBox();
            this.BtnEditar1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCrear1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Dgv = new System.Windows.Forms.DataGridView();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.LblHora = new System.Windows.Forms.Label();
            this.Hora = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(74)))));
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(25)))), ((int)(((byte)(74)))));
            this.splitContainer1.Panel1.Controls.Add(this.LblHora);
            this.splitContainer1.Panel1.Controls.Add(this.BtnEliminar1);
            this.splitContainer1.Panel1.Controls.Add(this.TxtBuscador);
            this.splitContainer1.Panel1.Controls.Add(this.BtnEditar1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.BtnCrear1);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox2);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Dgv);
            this.splitContainer1.Size = new System.Drawing.Size(781, 314);
            this.splitContainer1.SplitterDistance = 77;
            this.splitContainer1.TabIndex = 0;
            // 
            // BtnEliminar1
            // 
            this.BtnEliminar1.AllowAnimations = true;
            this.BtnEliminar1.AllowMouseEffects = true;
            this.BtnEliminar1.AllowToggling = false;
            this.BtnEliminar1.AnimationSpeed = 200;
            this.BtnEliminar1.AutoGenerateColors = false;
            this.BtnEliminar1.AutoRoundBorders = false;
            this.BtnEliminar1.AutoSizeLeftIcon = true;
            this.BtnEliminar1.AutoSizeRightIcon = true;
            this.BtnEliminar1.BackColor = System.Drawing.Color.Transparent;
            this.BtnEliminar1.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.BtnEliminar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEliminar1.BackgroundImage")));
            this.BtnEliminar1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.BtnEliminar1.ButtonText = "Eliminar";
            this.BtnEliminar1.ButtonTextMarginLeft = 0;
            this.BtnEliminar1.ColorContrastOnClick = 45;
            this.BtnEliminar1.ColorContrastOnHover = 45;
            this.BtnEliminar1.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges10.BottomLeft = true;
            borderEdges10.BottomRight = true;
            borderEdges10.TopLeft = true;
            borderEdges10.TopRight = true;
            this.BtnEliminar1.CustomizableEdges = borderEdges10;
            this.BtnEliminar1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnEliminar1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnEliminar1.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnEliminar1.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnEliminar1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.BtnEliminar1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar1.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar1.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEliminar1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.BtnEliminar1.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.BtnEliminar1.IconMarginLeft = 11;
            this.BtnEliminar1.IconPadding = 10;
            this.BtnEliminar1.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEliminar1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.BtnEliminar1.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.BtnEliminar1.IconSize = 25;
            this.BtnEliminar1.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(220)))));
            this.BtnEliminar1.IdleBorderRadius = 1;
            this.BtnEliminar1.IdleBorderThickness = 1;
            this.BtnEliminar1.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.BtnEliminar1.IdleIconLeftImage = null;
            this.BtnEliminar1.IdleIconRightImage = null;
            this.BtnEliminar1.IndicateFocus = false;
            this.BtnEliminar1.Location = new System.Drawing.Point(275, 12);
            this.BtnEliminar1.Name = "BtnEliminar1";
            this.BtnEliminar1.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnEliminar1.OnDisabledState.BorderRadius = 1;
            this.BtnEliminar1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.BtnEliminar1.OnDisabledState.BorderThickness = 1;
            this.BtnEliminar1.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnEliminar1.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnEliminar1.OnDisabledState.IconLeftImage = null;
            this.BtnEliminar1.OnDisabledState.IconRightImage = null;
            this.BtnEliminar1.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.BtnEliminar1.onHoverState.BorderRadius = 1;
            this.BtnEliminar1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.BtnEliminar1.onHoverState.BorderThickness = 1;
            this.BtnEliminar1.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.BtnEliminar1.onHoverState.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar1.onHoverState.IconLeftImage = null;
            this.BtnEliminar1.onHoverState.IconRightImage = null;
            this.BtnEliminar1.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(220)))));
            this.BtnEliminar1.OnIdleState.BorderRadius = 1;
            this.BtnEliminar1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.BtnEliminar1.OnIdleState.BorderThickness = 1;
            this.BtnEliminar1.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.BtnEliminar1.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar1.OnIdleState.IconLeftImage = null;
            this.BtnEliminar1.OnIdleState.IconRightImage = null;
            this.BtnEliminar1.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BtnEliminar1.OnPressedState.BorderRadius = 1;
            this.BtnEliminar1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.BtnEliminar1.OnPressedState.BorderThickness = 1;
            this.BtnEliminar1.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BtnEliminar1.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar1.OnPressedState.IconLeftImage = null;
            this.BtnEliminar1.OnPressedState.IconRightImage = null;
            this.BtnEliminar1.Size = new System.Drawing.Size(72, 48);
            this.BtnEliminar1.TabIndex = 4;
            this.BtnEliminar1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnEliminar1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnEliminar1.TextMarginLeft = 0;
            this.BtnEliminar1.TextPadding = new System.Windows.Forms.Padding(0);
            this.BtnEliminar1.UseDefaultRadiusAndThickness = true;
            this.BtnEliminar1.Click += new System.EventHandler(this.BtnEliminar1_Click);
            // 
            // TxtBuscador
            // 
            this.TxtBuscador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(41)))), ((int)(((byte)(86)))));
            this.TxtBuscador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBuscador.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscador.ForeColor = System.Drawing.Color.White;
            this.TxtBuscador.Location = new System.Drawing.Point(532, 26);
            this.TxtBuscador.Name = "TxtBuscador";
            this.TxtBuscador.Size = new System.Drawing.Size(224, 19);
            this.TxtBuscador.TabIndex = 5;
            this.TxtBuscador.TextChanged += new System.EventHandler(this.TxtBuscador_TextChanged);
            // 
            // BtnEditar1
            // 
            this.BtnEditar1.AllowAnimations = true;
            this.BtnEditar1.AllowMouseEffects = true;
            this.BtnEditar1.AllowToggling = false;
            this.BtnEditar1.AnimationSpeed = 200;
            this.BtnEditar1.AutoGenerateColors = false;
            this.BtnEditar1.AutoRoundBorders = false;
            this.BtnEditar1.AutoSizeLeftIcon = true;
            this.BtnEditar1.AutoSizeRightIcon = true;
            this.BtnEditar1.BackColor = System.Drawing.Color.Transparent;
            this.BtnEditar1.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.BtnEditar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEditar1.BackgroundImage")));
            this.BtnEditar1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.BtnEditar1.ButtonText = "Editar";
            this.BtnEditar1.ButtonTextMarginLeft = 0;
            this.BtnEditar1.ColorContrastOnClick = 45;
            this.BtnEditar1.ColorContrastOnHover = 45;
            this.BtnEditar1.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges11.BottomLeft = true;
            borderEdges11.BottomRight = true;
            borderEdges11.TopLeft = true;
            borderEdges11.TopRight = true;
            this.BtnEditar1.CustomizableEdges = borderEdges11;
            this.BtnEditar1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnEditar1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnEditar1.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnEditar1.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnEditar1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.BtnEditar1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar1.ForeColor = System.Drawing.Color.White;
            this.BtnEditar1.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEditar1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.BtnEditar1.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.BtnEditar1.IconMarginLeft = 11;
            this.BtnEditar1.IconPadding = 10;
            this.BtnEditar1.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEditar1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.BtnEditar1.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.BtnEditar1.IconSize = 25;
            this.BtnEditar1.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(220)))));
            this.BtnEditar1.IdleBorderRadius = 1;
            this.BtnEditar1.IdleBorderThickness = 1;
            this.BtnEditar1.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.BtnEditar1.IdleIconLeftImage = null;
            this.BtnEditar1.IdleIconRightImage = null;
            this.BtnEditar1.IndicateFocus = false;
            this.BtnEditar1.Location = new System.Drawing.Point(188, 12);
            this.BtnEditar1.Name = "BtnEditar1";
            this.BtnEditar1.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnEditar1.OnDisabledState.BorderRadius = 1;
            this.BtnEditar1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.BtnEditar1.OnDisabledState.BorderThickness = 1;
            this.BtnEditar1.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnEditar1.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnEditar1.OnDisabledState.IconLeftImage = null;
            this.BtnEditar1.OnDisabledState.IconRightImage = null;
            this.BtnEditar1.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.BtnEditar1.onHoverState.BorderRadius = 1;
            this.BtnEditar1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.BtnEditar1.onHoverState.BorderThickness = 1;
            this.BtnEditar1.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.BtnEditar1.onHoverState.ForeColor = System.Drawing.Color.White;
            this.BtnEditar1.onHoverState.IconLeftImage = null;
            this.BtnEditar1.onHoverState.IconRightImage = null;
            this.BtnEditar1.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(220)))));
            this.BtnEditar1.OnIdleState.BorderRadius = 1;
            this.BtnEditar1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.BtnEditar1.OnIdleState.BorderThickness = 1;
            this.BtnEditar1.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.BtnEditar1.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.BtnEditar1.OnIdleState.IconLeftImage = null;
            this.BtnEditar1.OnIdleState.IconRightImage = null;
            this.BtnEditar1.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BtnEditar1.OnPressedState.BorderRadius = 1;
            this.BtnEditar1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.BtnEditar1.OnPressedState.BorderThickness = 1;
            this.BtnEditar1.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BtnEditar1.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.BtnEditar1.OnPressedState.IconLeftImage = null;
            this.BtnEditar1.OnPressedState.IconRightImage = null;
            this.BtnEditar1.Size = new System.Drawing.Size(72, 48);
            this.BtnEditar1.TabIndex = 3;
            this.BtnEditar1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnEditar1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnEditar1.TextMarginLeft = 0;
            this.BtnEditar1.TextPadding = new System.Windows.Forms.Padding(0);
            this.BtnEditar1.UseDefaultRadiusAndThickness = true;
            this.BtnEditar1.Click += new System.EventHandler(this.BtnEditar1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(363, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Buscar Empresa";
            // 
            // BtnCrear1
            // 
            this.BtnCrear1.AllowAnimations = true;
            this.BtnCrear1.AllowMouseEffects = true;
            this.BtnCrear1.AllowToggling = false;
            this.BtnCrear1.AnimationSpeed = 200;
            this.BtnCrear1.AutoGenerateColors = false;
            this.BtnCrear1.AutoRoundBorders = false;
            this.BtnCrear1.AutoSizeLeftIcon = true;
            this.BtnCrear1.AutoSizeRightIcon = true;
            this.BtnCrear1.BackColor = System.Drawing.Color.Transparent;
            this.BtnCrear1.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.BtnCrear1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCrear1.BackgroundImage")));
            this.BtnCrear1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.BtnCrear1.ButtonText = "Crear";
            this.BtnCrear1.ButtonTextMarginLeft = 0;
            this.BtnCrear1.ColorContrastOnClick = 45;
            this.BtnCrear1.ColorContrastOnHover = 45;
            this.BtnCrear1.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges12.BottomLeft = true;
            borderEdges12.BottomRight = true;
            borderEdges12.TopLeft = true;
            borderEdges12.TopRight = true;
            this.BtnCrear1.CustomizableEdges = borderEdges12;
            this.BtnCrear1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnCrear1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnCrear1.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnCrear1.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnCrear1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.BtnCrear1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCrear1.ForeColor = System.Drawing.Color.White;
            this.BtnCrear1.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCrear1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.BtnCrear1.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.BtnCrear1.IconMarginLeft = 11;
            this.BtnCrear1.IconPadding = 10;
            this.BtnCrear1.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCrear1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.BtnCrear1.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.BtnCrear1.IconSize = 25;
            this.BtnCrear1.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(220)))));
            this.BtnCrear1.IdleBorderRadius = 1;
            this.BtnCrear1.IdleBorderThickness = 1;
            this.BtnCrear1.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.BtnCrear1.IdleIconLeftImage = null;
            this.BtnCrear1.IdleIconRightImage = null;
            this.BtnCrear1.IndicateFocus = false;
            this.BtnCrear1.Location = new System.Drawing.Point(101, 12);
            this.BtnCrear1.Name = "BtnCrear1";
            this.BtnCrear1.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnCrear1.OnDisabledState.BorderRadius = 1;
            this.BtnCrear1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.BtnCrear1.OnDisabledState.BorderThickness = 1;
            this.BtnCrear1.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnCrear1.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnCrear1.OnDisabledState.IconLeftImage = null;
            this.BtnCrear1.OnDisabledState.IconRightImage = null;
            this.BtnCrear1.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.BtnCrear1.onHoverState.BorderRadius = 1;
            this.BtnCrear1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.BtnCrear1.onHoverState.BorderThickness = 1;
            this.BtnCrear1.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.BtnCrear1.onHoverState.ForeColor = System.Drawing.Color.White;
            this.BtnCrear1.onHoverState.IconLeftImage = null;
            this.BtnCrear1.onHoverState.IconRightImage = null;
            this.BtnCrear1.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(220)))));
            this.BtnCrear1.OnIdleState.BorderRadius = 1;
            this.BtnCrear1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.BtnCrear1.OnIdleState.BorderThickness = 1;
            this.BtnCrear1.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.BtnCrear1.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.BtnCrear1.OnIdleState.IconLeftImage = null;
            this.BtnCrear1.OnIdleState.IconRightImage = null;
            this.BtnCrear1.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BtnCrear1.OnPressedState.BorderRadius = 1;
            this.BtnCrear1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.BtnCrear1.OnPressedState.BorderThickness = 1;
            this.BtnCrear1.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BtnCrear1.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.BtnCrear1.OnPressedState.IconLeftImage = null;
            this.BtnCrear1.OnPressedState.IconRightImage = null;
            this.BtnCrear1.Size = new System.Drawing.Size(72, 48);
            this.BtnCrear1.TabIndex = 2;
            this.BtnCrear1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnCrear1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnCrear1.TextMarginLeft = 0;
            this.BtnCrear1.TextPadding = new System.Windows.Forms.Padding(0);
            this.BtnCrear1.UseDefaultRadiusAndThickness = true;
            this.BtnCrear1.Click += new System.EventHandler(this.BtnCrear1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(519, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(250, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Dgv
            // 
            this.Dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(170)))), ((int)(((byte)(221)))));
            this.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv.Location = new System.Drawing.Point(0, 0);
            this.Dgv.MultiSelect = false;
            this.Dgv.Name = "Dgv";
            this.Dgv.ReadOnly = true;
            this.Dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv.Size = new System.Drawing.Size(781, 233);
            this.Dgv.TabIndex = 0;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // LblHora
            // 
            this.LblHora.AutoSize = true;
            this.LblHora.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHora.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LblHora.Location = new System.Drawing.Point(362, 49);
            this.LblHora.Name = "LblHora";
            this.LblHora.Size = new System.Drawing.Size(70, 25);
            this.LblHora.TabIndex = 18;
            this.LblHora.Text = "label1";
            // 
            // Hora
            // 
            this.Hora.Enabled = true;
            this.Hora.Tick += new System.EventHandler(this.Hora_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 314);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " FormCompanyList";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView Dgv;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxtBuscador;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 BtnCrear1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 BtnEliminar1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 BtnEditar1;
        private System.Windows.Forms.Label LblHora;
        private System.Windows.Forms.Timer Hora;
    }
}

