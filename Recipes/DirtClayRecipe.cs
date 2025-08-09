using Eco.Gameplay.Components;
using Eco.Gameplay.Items.Recipes;
using Eco.Mods.TechTree;
using Eco.Shared.Localization;
using Eco.Gameplay.Skills;

namespace EcoNova_Mod.Recipes;

[RequiresSkill(typeof(MiningSkill), 1)]  // nécessite le métier de minage niveau 1
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
        this.LaborInCalories = CreateLaborInCaloriesValue(50, typeof(MiningSkill));
        this.CraftMinutes = CreateCraftTimeValue(typeof(DirtClayRecipe), 0.5f, typeof(MiningSkill));
        this.Initialize(Localizer.DoStr("Argile de terre"), typeof(DirtClayRecipe));
        CraftingComponent.AddRecipe(typeof(RockerBoxObject), this); // Craft dans la rampe de lavage
    }
}