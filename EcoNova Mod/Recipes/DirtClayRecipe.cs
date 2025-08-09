using Eco.Gameplay.Components;
using Eco.Gameplay.Items.Recipes;
using Eco.Mods.TechTree;
using Eco.Shared.Localization;

namespace EcoNova_Mod.Recipes;

public class DirtClayRecipe : RecipeFamily
{
    public DirtClayRecipe()
    {
        this.Recipes = new List<Recipe>
        {
            new Recipe(
                    "Argile de terre",
                    Localizer.DoStr("Argile de terre"),
                    new IngredientElement[]
                    {
                        new IngredientElement(typeof(DirtItem), 5),         // Terre x1
                    },
                    new CraftingElement<ClayItem>()               // Produit 1 argile
                ),
        };
        
        this.ExperienceOnCraft = 1;       
        this.LaborInCalories = CreateLaborInCaloriesValue(20);
        this.CraftMinutes = CreateCraftTimeValue(typeof(DirtClayRecipe), 0.2f, null);
        this.Initialize(Localizer.DoStr("Argile de terre"), typeof(DirtClayRecipe));
        CraftingComponent.AddRecipe(typeof(WorkbenchObject), this); // Craft dans la Workbench
    }
}