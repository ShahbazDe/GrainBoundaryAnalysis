namespace GBEvaluationLibrary.Models
{
    public class UserModel
    {
        /// <summary>
        /// It contains the user id which consists of 4 digits. It is issued by the department.
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// It contains the name of the scientist who will be submitting the sample.
        /// </summary>
        public string UserName { get; set; }
    }
}
