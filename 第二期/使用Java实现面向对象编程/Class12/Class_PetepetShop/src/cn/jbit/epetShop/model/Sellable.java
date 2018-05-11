/**
 * 
 */
package cn.jbit.epetShop.model;

import cn.jbit.epetShop.entity.Pet;

/**
 * @author 北大青鸟 宠物卖接口
 */
public interface Sellable {
	/**
	 * 卖宠物
	 */
	public void sell(Pet pet);
}
