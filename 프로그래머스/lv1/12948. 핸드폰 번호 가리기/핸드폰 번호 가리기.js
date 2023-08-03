function solution(phone_number) {
    var phoneArray = phone_number.split('');
    for(var i = 0; i < phoneArray.length-4; i++){
         phoneArray[i]="*"
    }
    phoneArray = phoneArray.join('');
    return phoneArray;
}