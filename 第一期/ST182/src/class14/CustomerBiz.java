package class14;



public class CustomerBiz {
	
	public void getCustomer(String[] customer){
		System.out.println("*********************\n");
		System.out.println("�ͻ������б�");
		System.out.println("*********************\n");
		for(int i = 0 ; i < customer.length ; i++){
			if(customer[i].equals("null")){
							
							break;
						}
			System.out.print(customer[i] + "\t");
			
		}
	}
	
}
