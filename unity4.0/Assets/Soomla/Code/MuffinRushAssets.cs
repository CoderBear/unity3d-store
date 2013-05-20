using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace com.soomla.unity.example
{
	public class MuffinRushAssets : IStoreAssets
	{
		
		public int GetVersion ()
		{
			return 0;
		}
		
		public VirtualCurrency[] GetCurrencies ()
		{
			return new VirtualCurrency[]{MUFFIN_CURRENCY};
		}
		
		public VirtualGood[] GetGoods ()
		{
			return new VirtualGood[] {MUFFINCAKE_GOOD, PAVLOVA_GOOD,CHOCLATECAKE_GOOD, CREAMCUP_GOOD, CREAMCUP_UPGRADE, CHEFS_CAP, CHEFS_HAT, CHEFS_PAN};
		}
		
		public VirtualCurrencyPack[] GetCurrencyPacks ()
		{
			return new VirtualCurrencyPack[] {TENMUFF_PACK, FIFTYMUFF_PACK, FOURHUNDMUFF_PACK, THOUSANDMUFF_PACK};
		}
		
		public VirtualCategory[] GetCategories ()
		{
			return new VirtualCategory[]{GENERAL_CATEGORY, CAP_CATEGORY};
		}
		
		public NonConsumableItem[] GetNonConsumableItems ()
		{
			return new NonConsumableItem[]{NO_ADDS_NONCONS};
		}
		
		/** Static Final members **/
	
		public const string MUFFIN_CURRENCY_ITEM_ID = "currency_muffin";
		public const string TENMUFF_PACK_PRODUCT_ID = "android.test.refunded";
		public const string FIFTYMUFF_PACK_PRODUCT_ID = "android.test.canceled";
		public const string FOURHUNDMUFF_PACK_PRODUCT_ID = "android.test.purchased";
		public const string THOUSANDMUFF_PACK_PRODUCT_ID = "android.test.item_unavailable";
		public const string NO_ADDS_NONCONS_PRODUCT_ID = "no_ads";
		public const string MUFFINCAKE_ITEM_ID = "fruit_cake";
		public const string PAVLOVA_ITEM_ID = "pavlova";
		public const string CHOCLATECAKE_ITEM_ID = "chocolate_cake";
		public const string CREAMCUP_ITEM_ID = "cream_cup";
		public const string CREAMCUP_UPGRADE_ITEM_ID = "cream_cup_upgrade";
		public const string CHEFSCAP_ITEM_ID = "chefs_cap";
		public const string CHEFSHAT_ITEM_ID = "chefs_hat";
		public const string CHEFSPAN_ITEM_ID = "chefs_pan";
	
		/** Virtual Currencies **/
		public static VirtualCurrency MUFFIN_CURRENCY = new VirtualCurrency (
	            "Muffins",
	            "",
	            MUFFIN_CURRENCY_ITEM_ID
	    );
		

		/** Virtual Currency Packs **/
	
		public static VirtualCurrencyPack TENMUFF_PACK = new VirtualCurrencyPack (
	            "10 Muffins", // name
	            "Test refund of an item", // description
	            "muffins_10", // item id
				10, // number of currencies in the pack
	            MUFFIN_CURRENCY_ITEM_ID, // the currency associated with this pack
	            new PurchaseWithMarket (TENMUFF_PACK_PRODUCT_ID, 0.99)
		);
		public static VirtualCurrencyPack FIFTYMUFF_PACK = new VirtualCurrencyPack (
	            "50 Muffins", // name
	            "Test cancellation of an item", // description
	            "muffins_50", // item id
				50, // number of currencies in the pack
				MUFFIN_CURRENCY_ITEM_ID, // the currency associated with this pack
	            new PurchaseWithMarket (FIFTYMUFF_PACK_PRODUCT_ID, 1.99)
		);
		public static VirtualCurrencyPack FOURHUNDMUFF_PACK = new VirtualCurrencyPack (
	            "400 Muffins", // name
	            "Test purchase of an item", // description
	            "muffins_400", // item id
				400, // number of currencies in the pack
				MUFFIN_CURRENCY_ITEM_ID, // the currency associated with this pack
	            new PurchaseWithMarket (FOURHUNDMUFF_PACK_PRODUCT_ID, 4.99)
		);
		public static VirtualCurrencyPack THOUSANDMUFF_PACK = new VirtualCurrencyPack (
	            "1000 Muffins", // name
	            "Test item unavailable", // description
	            "muffins_1000", // item id
				1000, // number of currencies in the pack
				MUFFIN_CURRENCY_ITEM_ID, // the currency associated with this pack
	            new PurchaseWithMarket (THOUSANDMUFF_PACK_PRODUCT_ID, 8.99)
		);
	
		/** Virtual Goods **/
		
		public static VirtualGood MUFFINCAKE_GOOD = new SingleUseVG (
	            "Fruit Cake", // name
	            "Customers buy a double portion on each purchase of this cake", // description
	            "fruit_cake", // item id
	            new PurchaseWithVirtualItem (MUFFIN_CURRENCY_ITEM_ID, 225)); // the way this virtual good is purchased
	
		public static VirtualGood PAVLOVA_GOOD = new SingleUseVG (
	            "Pavlova", // name
	            "Gives customers a sugar rush and they call their friends", // description
	            "pavlova", // item id
	            new PurchaseWithVirtualItem (MUFFIN_CURRENCY_ITEM_ID, 175)); // the way this virtual good is purchased
	
		public static VirtualGood CHOCLATECAKE_GOOD = new SingleUseVG (
	            "Chocolate Cake", // name
	            "A classic cake to maximize customer satisfaction", // description
	            "chocolate_cake", // item id
	            new PurchaseWithVirtualItem (MUFFIN_CURRENCY_ITEM_ID, 250)); // the way this virtual good is purchased
	
	
		public static VirtualGood CREAMCUP_GOOD = new SingleUseVG (
	            "Cream Cup", // name
	            "Increase bakery reputation with this original pastry", // description
	            "cream_cup", // item id
	            new PurchaseWithVirtualItem (MUFFIN_CURRENCY_ITEM_ID, 50));  // the way this virtual good is purchased
		
		public static VirtualGood CREAMCUP_UPGRADE = new UpgradeVG ("cream_cup", "", "cream_cup",
			CREAMCUP_GOOD.Name, "Further Increasy Bakery Reputatiom", "cream_cup_upgrade",
			new PurchaseWithVirtualItem (MUFFIN_CURRENCY_ITEM_ID, 100));
		
		/** Virtual Categories **/
		// The muffin rush theme doesn't support categories, so we just put everything under a general category.
		public static VirtualCategory GENERAL_CATEGORY = new VirtualCategory (
	            "General", new List<string> (new string[] { MUFFINCAKE_ITEM_ID, PAVLOVA_ITEM_ID, CHOCLATECAKE_ITEM_ID, CREAMCUP_ITEM_ID, CREAMCUP_UPGRADE_ITEM_ID, CHEFSPAN_ITEM_ID })
	    );
		public static VirtualCategory CAP_CATEGORY = new VirtualCategory ("Caps", new List<string> (new string[] { CHEFSCAP_ITEM_ID, CHEFSHAT_ITEM_ID }));
		
		public static VirtualGood CHEFS_CAP = new EquippableVG (EquippableVG.EquippingModel.GLOBAL, "Chef Cap", "Double Customer's Satisfaction", "chefs_cap", new PurchaseWithVirtualItem (MUFFIN_CURRENCY_ITEM_ID, 500));
		public static VirtualGood CHEFS_HAT = new EquippableVG (EquippableVG.EquippingModel.CATEGORY, "Chef Hat", "Doubles customer satisfaction from goods", "chefs_hat", new PurchaseWithVirtualItem (MUFFIN_CURRENCY_ITEM_ID, 500));
		public static VirtualGood CHEFS_PAN = new EquippableVG (EquippableVG.EquippingModel.LOCAL, "Chef Pan", "Doubles the taste in half the time", "chefs_pan", new PurchaseWithVirtualItem (MUFFIN_CURRENCY_ITEM_ID, 1000));
		
		
		/** Google MANAGED Items **/
	
		public static NonConsumableItem NO_ADDS_NONCONS = new NonConsumableItem (
            "No Ads",
            "Test purchase of MANAGED item.",
            "no_ads",
            new PurchaseWithMarket (new MarketItem (NO_ADDS_NONCONS_PRODUCT_ID, MarketItem.Consumable.NONCONSUMABLE, 1.99))
    	);
		
	}
	
}