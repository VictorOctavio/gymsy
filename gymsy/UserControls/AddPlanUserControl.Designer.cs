namespace gymsy.UserControls
{
    partial class AddPlanUserControl
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            AddPlanUserConrol = new Label();
            SuspendLayout();
            // 
            // AddPlanUserConrol
            // 
            AddPlanUserConrol.Anchor = AnchorStyles.None;
            AddPlanUserConrol.AutoSize = true;
            AddPlanUserConrol.Font = new Font("Segoe UI", 23F, FontStyle.Regular, GraphicsUnit.Point);
            AddPlanUserConrol.Location = new Point(215, 167);
            AddPlanUserConrol.Name = "AddPlanUserConrol";
            AddPlanUserConrol.Size = new Size(286, 42);
            AddPlanUserConrol.TabIndex = 0;
            AddPlanUserConrol.Text = "AddPlanUserConrol";
            // 
            // AddPlanUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(AddPlanUserConrol);
            Margin = new Padding(0);
            Name = "AddPlanUserControl";
            Size = new Size(700, 400);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AddPlanUserConrol;
    }
}
