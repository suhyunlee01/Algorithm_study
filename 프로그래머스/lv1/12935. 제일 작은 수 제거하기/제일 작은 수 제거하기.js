function solution(arr) {
    var smaller = arr[0];
    var newarray = []
    for(var i = 0 ; i < arr.length; i++){
        if(arr.length > 1 && arr[i] < smaller){
                smaller = arr[i];
            }else if(arr.length <= 1){
                newarray.push(-1);
                return newarray;
            }
            }
    var removeIndex = arr.indexOf(smaller);
    arr.splice(removeIndex,1);
    return arr;
    }