/**
 * 
 */
package cn.jbit.epetShop.model;

import cn.jbit.epetShop.entity.Pet;

/**
 * @author �������� ���﹤���ӿ�
 */
public interface PetFactory {
	/**
	 * ������Ʒ�ֳ���
	 */
	public Pet breadNewPet(String[] petParam);
}
