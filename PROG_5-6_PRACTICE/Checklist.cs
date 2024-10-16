using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public class Checklist
{
    private List<ChecklistItem> _items;

    public Checklist()
    {
        _items = new List<ChecklistItem>
        {
            new ChecklistItem("Check fuel levels", 2),
            new ChecklistItem("Check navigation systems", 3),
            new ChecklistItem("Perform engine checks", 5),
            new ChecklistItem("Check weather conditions", 4),
            new ChecklistItem("Prepare for takeoff", 2)
        };
    }

    public async Task ExecuteChecklistAsync()
    {
        foreach (var item in _items)
        {
            await item.ExecuteAsync();
        }
    }
}
