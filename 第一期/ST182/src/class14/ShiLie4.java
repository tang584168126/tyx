package class14;

public class ShiLie4 {
	
	public double getavg(double[] score){
		double avg = 0;
		double sum = 0;
		int i = 0;
		for(i = 0 ; i < score.length ; i++){
			sum += score[i];
		}
		avg = sum / score.length;
		return avg;
	}
	public double getmax(double[] score){
		double max = 0;
		max = score[0];
		int i = 0;
		for(i = 0 ; i < score.length ; i++){
			if(max < score[i]){
				max = score[i];
			}
		}
		return max;
	}

}
