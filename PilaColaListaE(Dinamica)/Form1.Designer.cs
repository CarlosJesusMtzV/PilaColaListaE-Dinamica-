namespace PilaColaListaE_Dinamica_
{
    partial class Form1
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
            btnPush = new Button();
            btnPop = new Button();
            btnPeekPila = new Button();
            btnPeekCola = new Button();
            btnDequeue = new Button();
            btnEnqueue = new Button();
            btnRemove = new Button();
            btnAddLast = new Button();
            btnAddFirst = new Button();
            btnShowFirst = new Button();
            label1 = new Label();
            label2 = new Label();
            llk = new Label();
            btnShowLast = new Button();
            txtValor = new TextBox();
            lstContenido = new ListBox();
            SuspendLayout();
            // 
            // btnPush
            // 
            btnPush.BackColor = Color.MistyRose;
            btnPush.Location = new Point(278, 36);
            btnPush.Name = "btnPush";
            btnPush.Size = new Size(115, 52);
            btnPush.TabIndex = 0;
            btnPush.Text = "Push";
            btnPush.UseVisualStyleBackColor = false;
            btnPush.Click += btnPush_Click;
            // 
            // btnPop
            // 
            btnPop.BackColor = Color.MistyRose;
            btnPop.Location = new Point(278, 120);
            btnPop.Name = "btnPop";
            btnPop.Size = new Size(115, 52);
            btnPop.TabIndex = 1;
            btnPop.Text = "Pop";
            btnPop.UseVisualStyleBackColor = false;
            btnPop.Click += btnPop_Click;
            // 
            // btnPeekPila
            // 
            btnPeekPila.BackColor = Color.MistyRose;
            btnPeekPila.Location = new Point(278, 197);
            btnPeekPila.Name = "btnPeekPila";
            btnPeekPila.Size = new Size(115, 52);
            btnPeekPila.TabIndex = 2;
            btnPeekPila.Text = "PeekPila";
            btnPeekPila.UseVisualStyleBackColor = false;
            btnPeekPila.Click += btnPeekPila_Click;
            // 
            // btnPeekCola
            // 
            btnPeekCola.BackColor = Color.MistyRose;
            btnPeekCola.Location = new Point(428, 197);
            btnPeekCola.Name = "btnPeekCola";
            btnPeekCola.Size = new Size(115, 52);
            btnPeekCola.TabIndex = 5;
            btnPeekCola.Text = "PeekCola";
            btnPeekCola.UseVisualStyleBackColor = false;
            btnPeekCola.Click += btnPeekCola_Click;
            // 
            // btnDequeue
            // 
            btnDequeue.BackColor = Color.MistyRose;
            btnDequeue.Location = new Point(428, 120);
            btnDequeue.Name = "btnDequeue";
            btnDequeue.Size = new Size(115, 52);
            btnDequeue.TabIndex = 4;
            btnDequeue.Text = "Dequeue";
            btnDequeue.UseVisualStyleBackColor = false;
            btnDequeue.Click += btnDequeue_Click;
            // 
            // btnEnqueue
            // 
            btnEnqueue.BackColor = Color.MistyRose;
            btnEnqueue.Location = new Point(428, 36);
            btnEnqueue.Name = "btnEnqueue";
            btnEnqueue.Size = new Size(115, 52);
            btnEnqueue.TabIndex = 3;
            btnEnqueue.Text = "Enqueue";
            btnEnqueue.UseVisualStyleBackColor = false;
            btnEnqueue.Click += btnEnqueue_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.MistyRose;
            btnRemove.Location = new Point(569, 197);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(115, 52);
            btnRemove.TabIndex = 8;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnAddLast
            // 
            btnAddLast.BackColor = Color.MistyRose;
            btnAddLast.Location = new Point(569, 120);
            btnAddLast.Name = "btnAddLast";
            btnAddLast.Size = new Size(115, 52);
            btnAddLast.TabIndex = 7;
            btnAddLast.Text = "AddLast";
            btnAddLast.UseVisualStyleBackColor = false;
            btnAddLast.Click += btnAddLast_Click;
            // 
            // btnAddFirst
            // 
            btnAddFirst.BackColor = Color.MistyRose;
            btnAddFirst.Location = new Point(569, 36);
            btnAddFirst.Name = "btnAddFirst";
            btnAddFirst.Size = new Size(115, 52);
            btnAddFirst.TabIndex = 6;
            btnAddFirst.Text = "AddFirst";
            btnAddFirst.UseVisualStyleBackColor = false;
            btnAddFirst.Click += btnAddFirst_Click;
            // 
            // btnShowFirst
            // 
            btnShowFirst.BackColor = Color.MistyRose;
            btnShowFirst.Location = new Point(569, 273);
            btnShowFirst.Name = "btnShowFirst";
            btnShowFirst.Size = new Size(115, 52);
            btnShowFirst.TabIndex = 9;
            btnShowFirst.Text = "ShowFirst";
            btnShowFirst.UseVisualStyleBackColor = false;
            btnShowFirst.Click += btnShowFirst_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(278, 0);
            label1.Name = "label1";
            label1.Size = new Size(76, 33);
            label1.TabIndex = 10;
            label1.Text = "Pila";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(441, 0);
            label2.Name = "label2";
            label2.Size = new Size(81, 33);
            label2.TabIndex = 11;
            label2.Text = "Cola";
            // 
            // llk
            // 
            llk.AutoSize = true;
            llk.Font = new Font("Stencil", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            llk.Location = new Point(570, 0);
            llk.Name = "llk";
            llk.Size = new Size(114, 33);
            llk.TabIndex = 12;
            llk.Text = "Lista E";
            // 
            // btnShowLast
            // 
            btnShowLast.BackColor = Color.MistyRose;
            btnShowLast.Location = new Point(690, 273);
            btnShowLast.Name = "btnShowLast";
            btnShowLast.Size = new Size(115, 52);
            btnShowLast.TabIndex = 13;
            btnShowLast.Text = "ShowLast";
            btnShowLast.UseVisualStyleBackColor = false;
            btnShowLast.Click += btnShowLast_Click;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(12, 36);
            txtValor.Multiline = true;
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(180, 52);
            txtValor.TabIndex = 14;
            // 
            // lstContenido
            // 
            lstContenido.FormattingEnabled = true;
            lstContenido.Location = new Point(12, 145);
            lstContenido.Name = "lstContenido";
            lstContenido.Size = new Size(218, 164);
            lstContenido.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(lstContenido);
            Controls.Add(txtValor);
            Controls.Add(btnShowLast);
            Controls.Add(llk);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnShowFirst);
            Controls.Add(btnRemove);
            Controls.Add(btnAddLast);
            Controls.Add(btnAddFirst);
            Controls.Add(btnPeekCola);
            Controls.Add(btnDequeue);
            Controls.Add(btnEnqueue);
            Controls.Add(btnPeekPila);
            Controls.Add(btnPop);
            Controls.Add(btnPush);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPush;
        private Button btnPop;
        private Button btnPeekPila;
        private Button btnPeekCola;
        private Button btnDequeue;
        private Button btnEnqueue;
        private Button btnRemove;
        private Button btnAddLast;
        private Button btnAddFirst;
        private Button btnShowFirst;
        private Label label1;
        private Label label2;
        private Label llk;
        private Button btnShowLast;
        private TextBox txtValor;
        private ListBox lstContenido;
    }
}
