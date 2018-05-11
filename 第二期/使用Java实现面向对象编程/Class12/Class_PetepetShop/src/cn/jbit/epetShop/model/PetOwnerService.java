/**
 * 
 */
package cn.jbit.epetShop.model;

import java.util.List;

import cn.jbit.epetShop.entity.Pet;
import cn.jbit.epetShop.entity.PetOwner;

/**
 * @author �������� �������˽ӿ�
 * 
 */
public interface PetOwnerService extends Sellable, Buyable {

	/**
	 * �������˵�¼
	 */
	public PetOwner login();

	/**
	 * ���ݳ������˱�ʶ����id����õ��ó����������г�����Ϣ
	 */
	public List<Pet> getMyPet(int ownerId);
}
