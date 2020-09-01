using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeProject
{
    public partial class BeefForm : Form
    {

        // the following code is from Kory's discussion. use if desired, but know that i had issues with it being
        // on the main form. i had to put within my personal form for the project instead

        public void setRecipe(string recipeName, string recipePrep, string recipeCook, string recipeYield, string recipeText, string cookingText)
        {
            this.recipeNameLabel.Text = recipeName;
            this.prepTimeLabel.Text = recipePrep;
            this.cookTimeLabel.Text = recipeCook;
            this.servingYieldLabel.Text = recipeYield;
            this.recipeIngredientText.Text = recipeText;
            this.recipeInstructionText.Text = cookingText;
        }

        private void beefButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            BeefForm beefSatay = new BeefForm();
            beefSatay.setRecipe(
                "Beef Satay", "prep time: 40 minutes", "cook time: 5 minutes", "Servings: 4",
                "1) a pound of flank steak\n\n" +
                "2) quarter cup of soy sauce\n\n" +
                "3) quarter cup of balsamic vinegar\n\n" +
                "4) a Tablespoon of minced garlic\n\n" +
                "5) a Tablespoon of honey",
                "Thinly slice the steak across the grain with each slice measuring about .25inches in thickness\n" +
                "\nOpen a sealable plastic bag and place within a bowl. Add the soy sauce, balsamic vinegar, minced garlic and honey to the bag. Whisk to combine.\n" +
                "\nAdd the slice steak to the bag, pushing out air before sealing. Shake the bag until beef has been thoroughly coated then place in the refridgerator for a minimum 30 minutes (can be stored overnight).\n" +
                "\nIf using wooden skewers, soak them in water 30 minutes prior to grilling.\n Preheat a grill pan or grill at lowest heat, brushing lightly with cooking oil of your choice.\n" +
                "\nRemove the bag, and remove the steak. Thread each steak onto a skewer. Turn up the heat to medium-high and place skewers on pan or grill.\n" +
                "\nCook for 3 minutes on one side, flip them once, and cook an additional 2 minutes on the other side or until desired degree of doneness.\n" +
                "\nRemove from heat source, plate, and serve with rice, noodles, or other side of choice.");
            beefSatay.ShowDialog();
        }

        private void beefButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            BeefForm beefCasserole = new BeefForm();
            beefCasserole.setRecipe(
                "Beef Casserole", "prep time: 15 minutes", "cook time: 1 hour", "Servings: 12",
                "1) 2 pounds of ground beef\n\n" +
                "2) one 10.5oz can of cream of condensed mushroom soup\n\n" +
                "3) one 10.5oz can of cream of cheddar cheese soup\n\n" +
                "4) 3 cups cubed frozen potatoes\n\n" +
                "5) one cup of shredded cheddar cheese divided in half\n\n" +
                "6) salt and pepper (OPTIONAL) garlic powder, chili flakes, and chili powder to taste",
                "Preheat oven to 350 degrees Fahrenheit\n" +
                "\nPreheat grill pan before placing ground beef onto pan, stir often ensuring no large clumps of beef," +
                "remove from heat and drain grease. Add to a large mixing bowl.\n" +
                "\nAdd cans of cream of mushroom and cheddar cheese soup, frozen cubed potatoes, and half of shredded cheddar to bowl.\n" +
                "\nSeason with salt, pepper, and additional seasonings while mixing everything together.\n" +
                "\nPour into greased 9in by 13in casserole dish, sprinkling the remaining shredded cheese on top. Cover with foil\n" +
                "\nBake for 30 minutes and carefully remove foil, bake for an additional 30 minutes.\n" +
                "\nRemove from oven and serve hot.");
            beefCasserole.ShowDialog();
        }

        private void beefButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            BeefForm beefStroganoff = new BeefForm();
            beefStroganoff.setRecipe(
                "Crock Pot Beef Stroganoff", "prep time: 10 minutes", "cook time: 3 hours", "Servings: 4",
                "1) 1 pound of stew meat\n\n" +
                "2) one 10.5oz can of cream of mushroom soup\n\n" +
                "3) one 10.5oz can of cream of onion soup (if not available, use 1 pack of lipton dry onion soup mix with can of cream of mushroom soup\n\n" +
                "4) 8oz bag of egg noodles\n\n" +
                "5) 1/2 cup of sour cream\n\n" +
                "6) 4oz can of sliced mushrooms",
                "In a crock pot toss in stew meat, cream of onion soup and can of mushroom soup\n" +
                "\nPlace lid on crock pot and cook on low for 3- 4 hours, depending on your crock pot.\n" +
                "\nAfter 3 - 4 hours, when meat is cooked through, stir well and turn off crock pot.\n" +
                "\nPrepare egg noodles according to package directions.\n" +
                "\nAdd sour cream to meat mixture just before serving.\n" +
                "\nServe immediately.\n");
            beefStroganoff.ShowDialog();
        }

        private void beefButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            BeefForm beefEnchiladas = new BeefForm();
            beefEnchiladas.setRecipe(
                "Beef Enchiladas", "prep time: 20 minutes", "cook time: 35 minutes", "Servings: 8",
                "1) 1 pound of lean ground beef\n\n" +
                "2) 1 cup chunky salsa\n\n" +
                "3) one 10oz can of red enchilada sauce\n\n" +
                "4) eight 8in tortillas of choice\n\n" +
                "5) 2 cups shredded mexican blend cheese",
                "Preheat the oven to 350°F and lightly spray a 9x13-inch baking dish with nonstick cooking spray\n" +
                "\nIn a large skillet, brown the ground beef over medium-high heat. Drain the excess fat away and return the meat to the skillet and to medium-low heat.\n" +
                "\nStir in the salsa and cook until heated through. Remove from the heat.\n" +
                "\nPour about 1/2 of the enchilada sauce in the bottom of the prepared baking dish.\n" +
                "\nWarm the tortillas according to the package directions. Add about 1/4 cup of the meat mixture down the center of each tortilla and top with about 1 heaping tablespoon of cheese.\n" +
                "\nTightly roll each tortilla up and place them in the dish, seam side down. Pour the remaining enchilada sauce over them and sprinkle the remaining cheese over.\n" +
                "\nTightly wrap the dish with aluminum foil and bake for 30 to 35 minutes.\n" +
                "\nRemove from oven carefully and serve");
            beefEnchiladas.ShowDialog();
        }

        private void beefButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            BeefForm beefStew = new BeefForm();
            beefStew.setRecipe(
                "Slow Cooked Beef Stew", "prep time: 10 minutes", "cook time: 6-8 hours", "Servings: 5",
                "1) two 16oz bags frozen stew vegetables (traditionally carrot, potato, onion, and celery)\n\n" +
                "2) two pounds cubed beef stew meat\n\n" +
                "3) one 10.75oz can of cream of mushroom soup\n\n" +
                "4) one 10.75oz can of condensed tomato soup\n\n" +
                "5) 1 package dry onion soup mix",
                "Place vegetables in the bottom of a slow cooker. Top with stew meat.\n" +
                "\nIn a bowl, combine the condensed soups and dry soup mix. Pour over stew meat.\n" +
                "\nCover slow cook and cook on low for 6-8 hours. Serves 5.");
            beefStew.ShowDialog();
        }
    }
}
