using System.Collections.Generic;

namespace PresseMots.Models
{
    public class CommentVM
    {
        public IEnumerable<Comment> Comments { get; set; }
        public int Wordcount { get; set; }
        public string Storytitle { get; set; }
        public string ShortStory { get; set; }
        public int? StoryId { get; set; }
    }
}
