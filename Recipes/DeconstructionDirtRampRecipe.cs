using Eco.Gameplay.Components;
using Eco.Gameplay.Items.Recipes;
using Eco.Mods.TechTree;
using Eco.Shared.Localization;

namespace EcoNova_Mod.Recipes;

public class DeconstructionDirtRampRecipe : RecipeFamily
{
    public DeconstructionDirtRampRecipe()
    {
        this.Recipes = new List<Recipe>
        {
            new Recipe(
                "Déconstruction de rampe en terre",
                Localizer.DoStr("Déconstruction de rampe en terre"),
                new IngredientElement[]
                {
                    new IngredientElement(typeof(DirtRampItem), 1),         // Rampe en terre x1
                },
                    new CraftingElement<DirtItem>(2)               // Produit 2 terre
                )
        };
        
        this.ExperienceOnCraft = 1;
        this.LaborInCalories = CreateLaborInCaloriesValue(20);
        this.CraftMinutes = CreateCraftTimeValue(typeof(DeconstructionDirtRampRecipe), 0.5f, null);
        this.Initialize(Localizer.DoStr("Déconstruction de rampe en terre"), typeof(DeconstructionDirtRampRecipe));
        CraftingComponent.AddRecipe(typeof(WorkbenchObject), this); // Craft dans la Workbench
    }
}