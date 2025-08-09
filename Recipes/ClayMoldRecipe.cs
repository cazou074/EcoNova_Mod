using Eco.Gameplay.Components;
using Eco.Gameplay.Items.Recipes;
using Eco.Gameplay.Skills;
using Eco.Mods.TechTree;
using Eco.Shared.Localization;

namespace EcoNova_Mod.Recipes;

[RequiresSkill(typeof(PotterySkill), 1)]
public class ClayMoldRecipe : RecipeFamily
{
    public ClayMoldRecipe()
    {
        this.Recipes = new List<Recipe>()
        {
            new Recipe(
                "Moule en argile",
                Localizer.DoStr("Moule en argile"),
                new IngredientElement[]
                {
                    new IngredientElement(typeof(ClayItem), 1),         // Argile x1
                },
                new CraftingElement<ClayMoldItem>(4)               // Produit 4 moules
                )
        };
        this.ExperienceOnCraft = 1;
        this.LaborInCalories = CreateLaborInCaloriesValue(50, typeof(PotterySkill));
        this.CraftMinutes = CreateCraftTimeValue(typeof(ClayMoldRecipe), 0.2f, typeof(PotterySkill));
        this.Initialize(Localizer.DoStr("Moule en argile"), typeof(ClayMoldRecipe));
        CraftingComponent.AddRecipe(typeof(PotteryTableObject), this); // Craft dans la table de potterie
    }
}