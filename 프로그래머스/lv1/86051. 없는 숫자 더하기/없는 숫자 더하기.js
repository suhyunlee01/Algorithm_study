function solution(numbers) {
    var sum = 0;
    var total = 0;
    for(var j = 1; j<=9; j++){
        total = total + j;
    }
    for(var i = 0; i < numbers.length; i++){
        for(var j =1; j<=9; j++){
            if(numbers[i] == j){
                sum = sum + numbers[i];
            }
        }
    }
    return total-sum;
}