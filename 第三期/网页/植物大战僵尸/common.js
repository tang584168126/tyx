var GLOBAL_FRAME = 48;

function convertIndex(index, height){
	switch(index){
		case 0:return 160 - height;
		case 1:return 260 - height;
		case 2:return 360 - height;
		case 3:return 460 - height;
		default:return 560 - height;
	}
}

var i = 0;
function isTouchingPlants(zombie){
	return i++ == 3 ? true : false;
}