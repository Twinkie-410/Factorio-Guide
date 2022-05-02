using System.Collections.Generic;

namespace Factorio_guide__WPF
{
    public class Recipe
    {
        public double Time { get; set; }
    
        public List<MaterialsAndRecipes> NeededRusourses{get; set; }
    }
}