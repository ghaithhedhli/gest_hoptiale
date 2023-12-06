<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_RDCjour
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_RDCjour))
        Me.aff_rdv = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.btn_supprimer = New System.Windows.Forms.Button()
        CType(Me.aff_rdv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'aff_rdv
        '
        Me.aff_rdv.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.aff_rdv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.aff_rdv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.aff_rdv.Location = New System.Drawing.Point(204, 59)
        Me.aff_rdv.Name = "aff_rdv"
        Me.aff_rdv.RowHeadersWidth = 62
        Me.aff_rdv.RowTemplate.Height = 28
        Me.aff_rdv.Size = New System.Drawing.Size(460, 163)
        Me.aff_rdv.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "code"
        Me.Column1.MinimumWidth = 8
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 150
        '
        'Column2
        '
        Me.Column2.HeaderText = "date_heure"
        Me.Column2.MinimumWidth = 8
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 150
        '
        'btn_supprimer
        '
        Me.btn_supprimer.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btn_supprimer.BackgroundImage = CType(resources.GetObject("btn_supprimer.BackgroundImage"), System.Drawing.Image)
        Me.btn_supprimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_supprimer.Location = New System.Drawing.Point(361, 259)
        Me.btn_supprimer.Name = "btn_supprimer"
        Me.btn_supprimer.Size = New System.Drawing.Size(157, 43)
        Me.btn_supprimer.TabIndex = 1
        Me.btn_supprimer.Text = "supprimer"
        Me.btn_supprimer.UseVisualStyleBackColor = False
        '
        'frm_RDCjour
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(799, 445)
        Me.Controls.Add(Me.btn_supprimer)
        Me.Controls.Add(Me.aff_rdv)
        Me.Name = "frm_RDCjour"
        Me.Text = "RDCjour"
        CType(Me.aff_rdv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents aff_rdv As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btn_supprimer As Button
End Class
