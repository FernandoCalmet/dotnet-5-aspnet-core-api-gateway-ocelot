using System.Collections.Generic;

namespace OcelotWebAPIGateway.DataTransfer
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public List<PostDTO> Posts { get; set; } = new List<PostDTO>();
    }
}
