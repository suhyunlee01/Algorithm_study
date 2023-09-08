function solution(n) {
    var num = Math.sqrt(n);
    if(num ** 2 == n && Number.isInteger(num)){
        return (num + 1) ** 2;
    }else{
        return -1;
    }
}