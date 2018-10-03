namespace MyXLLAddin1
{
    partial class XLLModule
    {
        /// <summary>
        /// Required by designer
        /// </summary>
        private System.ComponentModel.IContainer components;
 
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

        #region Component Designer generated code
        /// <summary>
        /// Required by designer support - do not modify
        /// the following method
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.adxExcelFunctionCategory1 = new AddinExpress.MSO.ADXExcelFunctionCategory(this.components);
			this.adxExcelFunctionDescriptor1 = new AddinExpress.MSO.ADXExcelFunctionDescriptor(this.components);
			// 
			// adxExcelFunctionCategory1
			// 
			this.adxExcelFunctionCategory1.CategoryName = "adxExcelFunctionCategory1";
			this.adxExcelFunctionCategory1.FunctionDescriptors.Add(this.adxExcelFunctionDescriptor1);
			// 
			// adxExcelFunctionDescriptor1
			// 
			this.adxExcelFunctionDescriptor1.Description = "Get Nine";
			this.adxExcelFunctionDescriptor1.FunctionName = "GetNine";
			this.adxExcelFunctionDescriptor1.IsThreadSafe = true;
			// 
			// XLLModule
			// 
			this.AddinName = "MyXLLAddin1";

        }
		#endregion

		public AddinExpress.MSO.ADXExcelFunctionCategory adxExcelFunctionCategory1;
		public AddinExpress.MSO.ADXExcelFunctionDescriptor adxExcelFunctionDescriptor1;
	}
}

