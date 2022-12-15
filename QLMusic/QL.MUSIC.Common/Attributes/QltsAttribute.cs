namespace QL.MUSIC.Common.Attributes
{
    /// <summary>
    /// Attribure dùng để xác định 1 property là khóa chính
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class PrimaryKeyAttribute : Attribute
    {
    }

    /// <summary>
    /// Attribure dùng để xác định 1 property không được để trống
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class IsNotNullOrEmptyAttribute : Attribute
    {
        #region Field

        /// <summary>
        /// Message lỗi trả về cho client
        /// </summary>
        public string ErrorMessage;

        #endregion

        #region Constructor

        public IsNotNullOrEmptyAttribute(string? errorMessage)
        {
            ErrorMessage = errorMessage;
        }

        #endregion
    }

    /// <summary>
    /// Attribure dùng để xác định 1 property không được trùng lặp
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class IsNotDuplicateAttribute : Attribute
    {
        #region Field

        /// <summary>
        /// Message lỗi trả về cho client
        /// </summary>
        public string ErrorMessage;

        #endregion

        #region Constructor

        public IsNotDuplicateAttribute(string errorMessage)
        {
            ErrorMessage = errorMessage;
        }

        #endregion
    }

    /// <summary>
    /// Attribute tạo tên cột phục vụ cho việc Export Excel
    /// </summary> 
    /// Created by: NNNNINH (26/11/2022)
    [AttributeUsage(AttributeTargets.Property)]
    public class ExcelColumnNameAttribute : Attribute
    {
        /// <summary>
        /// Tên cột
        /// </summary>
        public string ColumnName { get; set; }

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="columnName">Tên cột</param>
        /// Created by: NNNNINH (26/11/2022)
        public ExcelColumnNameAttribute(string columnName)
        {
            ColumnName = columnName;
        }
        #endregion
    }
}
