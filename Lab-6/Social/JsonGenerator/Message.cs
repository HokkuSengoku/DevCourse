namespace JsonGenerator;


using System;
using System.Collections.Generic;

public class Message
{
    public int AuthorId { get; set; }

    public List<int> Likes { get; set; }

    public int MessageId { get; set; }

    public DateTime SendDate { get; set; }

    public string Text { get; set; }
}
