using System.ComponentModel.DataAnnotations;

namespace ContosoSite.Metadata
{
    public class StudentMetadata
    {
        [StringLength(50)]
        public string FirstName;
    }
}