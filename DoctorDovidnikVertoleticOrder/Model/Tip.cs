using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TasksOrderVert1000.Model;

public class Tip
{ public int TipId { get; set; }
    public string TipName { get; set; }
    public string Description { get; set; }
    public DateTime Date { get; set; }
    public int Major { get; set; }
}