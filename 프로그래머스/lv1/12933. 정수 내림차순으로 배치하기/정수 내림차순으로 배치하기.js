function solution(n) {
    var num = String(n);
    var array = num.split('').map(Number);
    var temp;
    
    for(var i = 0; i < array.length-1; i++){
        for(var j = 0; j < array.length-1; j++){
            if(array[j] < array[j+1]){
                temp = array[j];
                array[j]=array[j+1];
                array[j+1]=temp;
            }
        }
    }
    array = array.join('');
    return array*1;
}