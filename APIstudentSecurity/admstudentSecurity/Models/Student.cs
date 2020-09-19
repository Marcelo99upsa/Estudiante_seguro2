namespace admstudentSecurity.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class Student
    {
        [Key] // No va a ser necesario poner StudentId
        public int StudentId { get; set; }

        [StringLength(30)] // Permite Hasta 30 caracteres
        [Required(ErrorMessage = "You must enter the field {0}")] // El 0 identifica al dato LastName
        public string LastName { get; set; }

        //Length 30=1,                                                              Minium=2
        [StringLength(30, ErrorMessage = "The field {0} must containt betwen {2} and {1} characters", MinimumLength = 2)] //El 0 hace referencia a firstname 
        [Required(ErrorMessage = "You must enter the field {0}")]
        public string FirstName { get; set; } //First name={0}

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/mm/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }
    }
}