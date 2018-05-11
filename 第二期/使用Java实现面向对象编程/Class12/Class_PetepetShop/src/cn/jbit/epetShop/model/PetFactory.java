/**
 * 
 */
package cn.jbit.epetShop.model;

import cn.jbit.epetShop.entity.Pet;

/**
 * @author 北大青鸟 宠物工厂接口
 */
public interface PetFactory {
	/**
	 * 培育新品种宠物
	 */
	public Pet breadNewPet(String[] petParam);
}
