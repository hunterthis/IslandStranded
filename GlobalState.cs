using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IslandStranded.Views; // use the views folder 
using IView = IslandStranded.Views.IView;
using Microsoft.EntityFrameworkCore;

namespace IslandStranded;

public class GlobalState
{
    public IView CurrentView { get; set; }

    public bool ShouldExit { get; set; }

    public UserContext UserDatabase { get; set; }

    public User? CurrentUser { get; set; }

    
}
