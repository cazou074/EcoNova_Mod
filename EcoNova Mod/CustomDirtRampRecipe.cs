using Eco.Gameplay.Components;
using Eco.Gameplay.Items.Recipes;
using Eco.Mods.TechTree;
using Eco.Shared.Localization;
using System.Runtime.Versioning;

[assembly: SupportedOSPlatform("windows")]

namespace EcoNova_Mod;


public class CustomDirtRampRecipe : RecipeFamily
{
    public CustomDirtRampRecipe()
    {
        this.Recipes = new List<Recipe>
        {
            new Recipe(
                "Dirt Ramp",
                Localizer.DoStr("Dirt Ramp"),
                new IngredientElement[]
                {
                    new IngredientElement("DirtItem", 2),         // Terre x2
                },
                new CraftingElement<DirtRampItem>()               // Produit 1 rampe
            )
        };

        this.LaborInCalories = CreateLaborInCaloriesValue(10, null);
        this.CraftMinutes = CreateCraftTimeValue(typeof(CustomDirtRampRecipe), 0.5f, null);
        this.Initialize(Localizer.DoStr("Dirt Ramp"), typeof(CustomDirtRampRecipe));
        CraftingComponent.AddRecipe(typeof(WorkbenchObject), this); // Craft dans la Workbench
    }
}