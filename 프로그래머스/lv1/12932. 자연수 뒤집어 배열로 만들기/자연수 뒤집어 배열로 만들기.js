function solution(n) {
    var numString = n.toString();
    var numArray = numString.split('');
    var newArray = [];
    for(var i = 0; i < numArray.length; i++){
        newArray[(numArray.length-1)-i] = numArray[i];
    }
    return newArray.map(Number);;
}