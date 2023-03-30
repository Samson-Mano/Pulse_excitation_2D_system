namespace Pulse_excitation_2D_system
{
    partial class Main_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_form));
            this.groupBox_import = new System.Windows.Forms.GroupBox();
            this.button_import_nodes = new System.Windows.Forms.Button();
            this.button_import_const = new System.Windows.Forms.Button();
            this.button_import_elements = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox_force = new System.Windows.Forms.GroupBox();
            this.button_set_initial = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button_force_single = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button_force_multi = new System.Windows.Forms.Button();
            this.groupBox_visualizer = new System.Windows.Forms.GroupBox();
            this.groupBox_solver = new System.Windows.Forms.GroupBox();
            this.button_solve = new System.Windows.Forms.Button();
            this.button_view_inpt = new System.Windows.Forms.Button();
            this.groupBox_import.SuspendLayout();
            this.groupBox_force.SuspendLayout();
            this.groupBox_solver.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_import
            // 
            this.groupBox_import.Controls.Add(this.label2);
            this.groupBox_import.Controls.Add(this.label1);
            this.groupBox_import.Controls.Add(this.button_import_elements);
            this.groupBox_import.Controls.Add(this.button_import_const);
            this.groupBox_import.Controls.Add(this.button_import_nodes);
            this.groupBox_import.Location = new System.Drawing.Point(12, 12);
            this.groupBox_import.Name = "groupBox_import";
            this.groupBox_import.Size = new System.Drawing.Size(225, 295);
            this.groupBox_import.TabIndex = 0;
            this.groupBox_import.TabStop = false;
            this.groupBox_import.Text = "Import Model";
            // 
            // button_import_nodes
            // 
            this.button_import_nodes.Location = new System.Drawing.Point(25, 43);
            this.button_import_nodes.Name = "button_import_nodes";
            this.button_import_nodes.Size = new System.Drawing.Size(169, 52);
            this.button_import_nodes.TabIndex = 0;
            this.button_import_nodes.Text = "Import Nodes";
            this.button_import_nodes.UseVisualStyleBackColor = true;
            // 
            // button_import_const
            // 
            this.button_import_const.Location = new System.Drawing.Point(25, 203);
            this.button_import_const.Name = "button_import_const";
            this.button_import_const.Size = new System.Drawing.Size(169, 52);
            this.button_import_const.TabIndex = 1;
            this.button_import_const.Text = "Import Constraint";
            this.button_import_const.UseVisualStyleBackColor = true;
            // 
            // button_import_elements
            // 
            this.button_import_elements.Location = new System.Drawing.Point(25, 123);
            this.button_import_elements.Name = "button_import_elements";
            this.button_import_elements.Size = new System.Drawing.Size(169, 52);
            this.button_import_elements.TabIndex = 2;
            this.button_import_elements.Text = "Import Elements";
            this.button_import_elements.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "|";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "|";
            // 
            // groupBox_force
            // 
            this.groupBox_force.Controls.Add(this.button_force_multi);
            this.groupBox_force.Controls.Add(this.label4);
            this.groupBox_force.Controls.Add(this.button_force_single);
            this.groupBox_force.Controls.Add(this.label3);
            this.groupBox_force.Controls.Add(this.button_set_initial);
            this.groupBox_force.Location = new System.Drawing.Point(243, 13);
            this.groupBox_force.Name = "groupBox_force";
            this.groupBox_force.Size = new System.Drawing.Size(225, 294);
            this.groupBox_force.TabIndex = 1;
            this.groupBox_force.TabStop = false;
            this.groupBox_force.Text = "Import Pulse Force";
            // 
            // button_set_initial
            // 
            this.button_set_initial.Location = new System.Drawing.Point(33, 42);
            this.button_set_initial.Name = "button_set_initial";
            this.button_set_initial.Size = new System.Drawing.Size(169, 52);
            this.button_set_initial.TabIndex = 0;
            this.button_set_initial.Text = "Set Initial Condition";
            this.button_set_initial.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "|";
            // 
            // button_force_single
            // 
            this.button_force_single.Location = new System.Drawing.Point(33, 122);
            this.button_force_single.Name = "button_force_single";
            this.button_force_single.Size = new System.Drawing.Size(169, 52);
            this.button_force_single.TabIndex = 5;
            this.button_force_single.Text = "Import Single Force Step";
            this.button_force_single.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Or";
            // 
            // button_force_multi
            // 
            this.button_force_multi.Location = new System.Drawing.Point(33, 202);
            this.button_force_multi.Name = "button_force_multi";
            this.button_force_multi.Size = new System.Drawing.Size(169, 52);
            this.button_force_multi.TabIndex = 7;
            this.button_force_multi.Text = "Import Multi Force Step";
            this.button_force_multi.UseVisualStyleBackColor = true;
            // 
            // groupBox_visualizer
            // 
            this.groupBox_visualizer.Location = new System.Drawing.Point(474, 12);
            this.groupBox_visualizer.Name = "groupBox_visualizer";
            this.groupBox_visualizer.Size = new System.Drawing.Size(296, 429);
            this.groupBox_visualizer.TabIndex = 2;
            this.groupBox_visualizer.TabStop = false;
            this.groupBox_visualizer.Text = "Visualizer";
            // 
            // groupBox_solver
            // 
            this.groupBox_solver.Controls.Add(this.button_view_inpt);
            this.groupBox_solver.Controls.Add(this.button_solve);
            this.groupBox_solver.Location = new System.Drawing.Point(12, 313);
            this.groupBox_solver.Name = "groupBox_solver";
            this.groupBox_solver.Size = new System.Drawing.Size(455, 128);
            this.groupBox_solver.TabIndex = 3;
            this.groupBox_solver.TabStop = false;
            this.groupBox_solver.Text = "Solver";
            // 
            // button_solve
            // 
            this.button_solve.Location = new System.Drawing.Point(264, 41);
            this.button_solve.Name = "button_solve";
            this.button_solve.Size = new System.Drawing.Size(169, 52);
            this.button_solve.TabIndex = 0;
            this.button_solve.Text = "Solve";
            this.button_solve.UseVisualStyleBackColor = true;
            // 
            // button_view_inpt
            // 
            this.button_view_inpt.Location = new System.Drawing.Point(25, 41);
            this.button_view_inpt.Name = "button_view_inpt";
            this.button_view_inpt.Size = new System.Drawing.Size(168, 51);
            this.button_view_inpt.TabIndex = 1;
            this.button_view_inpt.Text = "View Input";
            this.button_view_inpt.UseVisualStyleBackColor = true;
            // 
            // Main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.groupBox_solver);
            this.Controls.Add(this.groupBox_visualizer);
            this.Controls.Add(this.groupBox_force);
            this.Controls.Add(this.groupBox_import);
            this.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Main_form";
            this.Text = "2D System Pulse Excitation Solver ----- Developed By Samson Mano <saminnx@gmail.c" +
    "om>";
            this.groupBox_import.ResumeLayout(false);
            this.groupBox_import.PerformLayout();
            this.groupBox_force.ResumeLayout(false);
            this.groupBox_force.PerformLayout();
            this.groupBox_solver.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_import;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_import_elements;
        private System.Windows.Forms.Button button_import_const;
        private System.Windows.Forms.Button button_import_nodes;
        private System.Windows.Forms.GroupBox groupBox_force;
        private System.Windows.Forms.Button button_force_multi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_force_single;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_set_initial;
        private System.Windows.Forms.GroupBox groupBox_visualizer;
        private System.Windows.Forms.GroupBox groupBox_solver;
        private System.Windows.Forms.Button button_solve;
        private System.Windows.Forms.Button button_view_inpt;
    }
}