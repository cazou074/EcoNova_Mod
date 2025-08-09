using Eco.Gameplay.Components;
using Eco.Gameplay.Items.Recipes;
using Eco.Mods.TechTree;
using Eco.Shared.Localization;
using System.Runtime.Versioning;

[assembly: SupportedOSPlatform("windows")]

namespace EcoNova_Mod.Recipes;


public class DirtRampRecipe : RecipeFamily
{
    public DirtRampRecipe()
    {
        this.Recipes = new List<Recipe>
        {
            new Recipe(
                "Rampe en terre",
                Localizer.DoStr("Rampe en terre"),
                new IngredientElement[]
                {
                    new IngredientElement(typeof(DirtItem), 2),         // Terre x2
                },
                new CraftingElement<DirtRampItem>()               // Produit 1 rampe
            )
        };

        this.ExperienceOnCraft = 1;
        this.LaborInCalories = CreateLaborInCaloriesValue(20); // 20 calories
        this.CraftMinutes = CreateCraftTimeValue(typeof(DirtRampRecipe), 0.5f, null); // 30 secondes
        this.Initialize(Localizer.DoStr("Rampe en terre"), typeof(DirtRampRecipe));
        CraftingComponent.AddRecipe(typeof(WorkbenchObject), this); // Craft dans la Workbench
    }
}