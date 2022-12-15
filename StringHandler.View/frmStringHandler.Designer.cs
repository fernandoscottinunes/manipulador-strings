
namespace StringHandler.View
{
    partial class frmStringHandler
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblInputText = new System.Windows.Forms.Label();
            this.tbInputText = new System.Windows.Forms.TextBox();
            this.tbOutputText = new System.Windows.Forms.TextBox();
            this.btnUpperCase = new System.Windows.Forms.Button();
            this.btnLowerCase = new System.Windows.Forms.Button();
            this.btnReverseWord = new System.Windows.Forms.Button();
            this.btnReverseLetter = new System.Windows.Forms.Button();
            this.btnWordWrap = new System.Windows.Forms.Button();
            this.btnShuffleWord = new System.Windows.Forms.Button();
            this.btnShuffleLetter = new System.Windows.Forms.Button();
            this.btnCountWord = new System.Windows.Forms.Button();
            this.btnCountLetter = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgHistory = new System.Windows.Forms.DataGridView();
            this.columnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnInputText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFunction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCharacterCount = new System.Windows.Forms.Label();
            this.lblClearText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInputText
            // 
            this.lblInputText.AutoSize = true;
            this.lblInputText.Location = new System.Drawing.Point(9, 28);
            this.lblInputText.Margin = new System.Windows.Forms.Padding(0);
            this.lblInputText.Name = "lblInputText";
            this.lblInputText.Size = new System.Drawing.Size(106, 13);
            this.lblInputText.TabIndex = 1;
            this.lblInputText.Text = "Digite seu texto aqui:";
            // 
            // tbInputText
            // 
            this.tbInputText.Location = new System.Drawing.Point(12, 44);
            this.tbInputText.MaxLength = 250;
            this.tbInputText.Multiline = true;
            this.tbInputText.Name = "tbInputText";
            this.tbInputText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbInputText.Size = new System.Drawing.Size(861, 90);
            this.tbInputText.TabIndex = 2;
            this.tbInputText.TextChanged += new System.EventHandler(this.tbInputText_TextChanged);
            // 
            // tbOutputText
            // 
            this.tbOutputText.Location = new System.Drawing.Point(12, 282);
            this.tbOutputText.Multiline = true;
            this.tbOutputText.Name = "tbOutputText";
            this.tbOutputText.ReadOnly = true;
            this.tbOutputText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbOutputText.Size = new System.Drawing.Size(861, 90);
            this.tbOutputText.TabIndex = 13;
            // 
            // btnUpperCase
            // 
            this.btnUpperCase.Location = new System.Drawing.Point(241, 226);
            this.btnUpperCase.Name = "btnUpperCase";
            this.btnUpperCase.Size = new System.Drawing.Size(130, 25);
            this.btnUpperCase.TabIndex = 6;
            this.btnUpperCase.Text = "Todas em Maiúscula";
            this.btnUpperCase.UseVisualStyleBackColor = true;
            this.btnUpperCase.Click += new System.EventHandler(this.btnUpperCase_Click);
            // 
            // btnLowerCase
            // 
            this.btnLowerCase.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnLowerCase.Location = new System.Drawing.Point(377, 168);
            this.btnLowerCase.Name = "btnLowerCase";
            this.btnLowerCase.Size = new System.Drawing.Size(130, 25);
            this.btnLowerCase.TabIndex = 7;
            this.btnLowerCase.Text = "Todas em Minúscula";
            this.btnLowerCase.UseVisualStyleBackColor = true;
            this.btnLowerCase.Click += new System.EventHandler(this.btnLowerCase_Click);
            // 
            // btnReverseWord
            // 
            this.btnReverseWord.Location = new System.Drawing.Point(377, 197);
            this.btnReverseWord.Name = "btnReverseWord";
            this.btnReverseWord.Size = new System.Drawing.Size(130, 25);
            this.btnReverseWord.TabIndex = 8;
            this.btnReverseWord.Text = "Inverter Palavras";
            this.btnReverseWord.UseVisualStyleBackColor = true;
            this.btnReverseWord.Click += new System.EventHandler(this.btnReverseWord_Click);
            // 
            // btnReverseLetter
            // 
            this.btnReverseLetter.Location = new System.Drawing.Point(377, 226);
            this.btnReverseLetter.Name = "btnReverseLetter";
            this.btnReverseLetter.Size = new System.Drawing.Size(130, 25);
            this.btnReverseLetter.TabIndex = 9;
            this.btnReverseLetter.Text = "Inverter Caracteres";
            this.btnReverseLetter.UseVisualStyleBackColor = true;
            this.btnReverseLetter.Click += new System.EventHandler(this.btnReverseLetter_Click);
            // 
            // btnWordWrap
            // 
            this.btnWordWrap.Location = new System.Drawing.Point(513, 168);
            this.btnWordWrap.Name = "btnWordWrap";
            this.btnWordWrap.Size = new System.Drawing.Size(130, 25);
            this.btnWordWrap.TabIndex = 10;
            this.btnWordWrap.Text = "Quebrar Linhas";
            this.btnWordWrap.UseVisualStyleBackColor = true;
            this.btnWordWrap.Click += new System.EventHandler(this.btnWordWrap_Click);
            // 
            // btnShuffleWord
            // 
            this.btnShuffleWord.Location = new System.Drawing.Point(513, 197);
            this.btnShuffleWord.Name = "btnShuffleWord";
            this.btnShuffleWord.Size = new System.Drawing.Size(130, 25);
            this.btnShuffleWord.TabIndex = 11;
            this.btnShuffleWord.Text = "Embaralhar Palavras";
            this.btnShuffleWord.UseVisualStyleBackColor = true;
            this.btnShuffleWord.Click += new System.EventHandler(this.btnShuffleWord_Click);
            // 
            // btnShuffleLetter
            // 
            this.btnShuffleLetter.Location = new System.Drawing.Point(513, 226);
            this.btnShuffleLetter.Name = "btnShuffleLetter";
            this.btnShuffleLetter.Size = new System.Drawing.Size(130, 25);
            this.btnShuffleLetter.TabIndex = 12;
            this.btnShuffleLetter.Text = "Embaralhar Caracteres";
            this.btnShuffleLetter.UseVisualStyleBackColor = true;
            this.btnShuffleLetter.Click += new System.EventHandler(this.btnShuffleLetter_Click);
            // 
            // btnCountWord
            // 
            this.btnCountWord.Location = new System.Drawing.Point(241, 168);
            this.btnCountWord.Name = "btnCountWord";
            this.btnCountWord.Size = new System.Drawing.Size(130, 25);
            this.btnCountWord.TabIndex = 4;
            this.btnCountWord.Text = "Contar Palavras";
            this.btnCountWord.UseVisualStyleBackColor = true;
            this.btnCountWord.Click += new System.EventHandler(this.btnCountWord_Click);
            // 
            // btnCountLetter
            // 
            this.btnCountLetter.Location = new System.Drawing.Point(241, 197);
            this.btnCountLetter.Name = "btnCountLetter";
            this.btnCountLetter.Size = new System.Drawing.Size(130, 25);
            this.btnCountLetter.TabIndex = 5;
            this.btnCountLetter.Text = "Contar Caracteres";
            this.btnCountLetter.UseVisualStyleBackColor = true;
            this.btnCountLetter.Click += new System.EventHandler(this.btnCountLetter_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(9, 266);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(58, 13);
            this.lblResult.TabIndex = 15;
            this.lblResult.Text = "Resultado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Histórico:";
            // 
            // dgHistory
            // 
            this.dgHistory.AllowUserToAddRows = false;
            this.dgHistory.AllowUserToDeleteRows = false;
            this.dgHistory.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnId,
            this.columnInputText,
            this.columnFunction,
            this.columnResult,
            this.dateTime});
            this.dgHistory.Location = new System.Drawing.Point(12, 402);
            this.dgHistory.Name = "dgHistory";
            this.dgHistory.ReadOnly = true;
            this.dgHistory.Size = new System.Drawing.Size(861, 239);
            this.dgHistory.TabIndex = 14;
            // 
            // columnId
            // 
            this.columnId.DataPropertyName = "Id";
            this.columnId.HeaderText = "ID";
            this.columnId.Name = "columnId";
            this.columnId.ReadOnly = true;
            this.columnId.Width = 50;
            // 
            // columnInputText
            // 
            this.columnInputText.DataPropertyName = "InputText";
            this.columnInputText.HeaderText = "Input Text";
            this.columnInputText.Name = "columnInputText";
            this.columnInputText.ReadOnly = true;
            this.columnInputText.Width = 250;
            // 
            // columnFunction
            // 
            this.columnFunction.DataPropertyName = "FunctionUsed";
            this.columnFunction.HeaderText = "Function";
            this.columnFunction.Name = "columnFunction";
            this.columnFunction.ReadOnly = true;
            // 
            // columnResult
            // 
            this.columnResult.DataPropertyName = "OutputText";
            this.columnResult.HeaderText = "Result";
            this.columnResult.Name = "columnResult";
            this.columnResult.ReadOnly = true;
            this.columnResult.Width = 250;
            // 
            // dateTime
            // 
            this.dateTime.DataPropertyName = "DateAndTime";
            this.dateTime.HeaderText = "Date and Time";
            this.dateTime.Name = "dateTime";
            this.dateTime.ReadOnly = true;
            this.dateTime.Width = 150;
            // 
            // lblCharacterCount
            // 
            this.lblCharacterCount.AutoSize = true;
            this.lblCharacterCount.Location = new System.Drawing.Point(9, 141);
            this.lblCharacterCount.Name = "lblCharacterCount";
            this.lblCharacterCount.Size = new System.Drawing.Size(159, 13);
            this.lblCharacterCount.TabIndex = 18;
            this.lblCharacterCount.Text = "(Restam 250 de 250 caracteres)";
            // 
            // lblClearText
            // 
            this.lblClearText.AutoSize = true;
            this.lblClearText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClearText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClearText.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblClearText.Location = new System.Drawing.Point(838, 141);
            this.lblClearText.Margin = new System.Windows.Forms.Padding(0);
            this.lblClearText.Name = "lblClearText";
            this.lblClearText.Size = new System.Drawing.Size(38, 13);
            this.lblClearText.TabIndex = 3;
            this.lblClearText.Text = "Limpar";
            this.lblClearText.Click += new System.EventHandler(this.lblClearText_Click);
            // 
            // frmStringHandler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 653);
            this.Controls.Add(this.lblClearText);
            this.Controls.Add(this.lblCharacterCount);
            this.Controls.Add(this.dgHistory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCountLetter);
            this.Controls.Add(this.btnCountWord);
            this.Controls.Add(this.btnShuffleLetter);
            this.Controls.Add(this.btnShuffleWord);
            this.Controls.Add(this.btnWordWrap);
            this.Controls.Add(this.btnReverseLetter);
            this.Controls.Add(this.btnReverseWord);
            this.Controls.Add(this.btnLowerCase);
            this.Controls.Add(this.btnUpperCase);
            this.Controls.Add(this.tbOutputText);
            this.Controls.Add(this.tbInputText);
            this.Controls.Add(this.lblInputText);
            this.Name = "frmStringHandler";
            this.Text = "Manipulador de Strings";
            this.Load += new System.EventHandler(this.frmStringHandler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInputText;
        private System.Windows.Forms.TextBox tbInputText;
        private System.Windows.Forms.TextBox tbOutputText;
        private System.Windows.Forms.Button btnUpperCase;
        private System.Windows.Forms.Button btnLowerCase;
        private System.Windows.Forms.Button btnReverseWord;
        private System.Windows.Forms.Button btnReverseLetter;
        private System.Windows.Forms.Button btnWordWrap;
        private System.Windows.Forms.Button btnShuffleWord;
        private System.Windows.Forms.Button btnShuffleLetter;
        private System.Windows.Forms.Button btnCountWord;
        private System.Windows.Forms.Button btnCountLetter;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgHistory;
        private System.Windows.Forms.Label lblCharacterCount;
        private System.Windows.Forms.Label lblClearText;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnInputText;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFunction;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTime;
    }
}

