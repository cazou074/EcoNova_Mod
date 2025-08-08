using Eco.Gameplay.Components;
using Eco.Gameplay.Items.Recipes;
using Eco.Mods.TechTree;
using Eco.Shared.Localization;

namespace EcoNova_Mod;

public class DeconstructionDirtRampRecipe : RecipeFamily
{
    public DeconstructionDirtRampRecipe()
    {
        this.Recipes = new List<Recipe>
        {
            new Recipe(
                "Deconstruction Dirt Ramp",
                Localizer.DoStr("Deconstruction Dirt Ramp"),
                new IngredientElement[]
                {
                    new IngredientElement("DirtRampItem", 1),         // Rampe en terre x1
                },
                    new CraftingElement<DirtRampItem>()               // Produit 1 rampe
                )
        };
        this.LaborInCalories = CreateLaborInCaloriesValue(10, null);
        this.CraftMinutes = CreateCraftTimeValue(typeof(DeconstructionDirtRampRecipe), 0.5f, null);
        this.Initialize(Localizer.DoStr("Deconstruction Dirt Ramp"), typeof(DeconstructionDirtRampRecipe));
        CraftingComponent.AddRecipe(typeof(WorkbenchObject), this); // Craft dans la Workbench
    }
}