function thuchien(){
    const getidhang = document.getElementById("txtHang");
    const getidselect = document.getElementById("ddlDanhsachhangsx");
    
    getidselect.innerHTML += `<option value=${getidhang.value}">${getidhang.value}</option>`;
    document.getElementById("txtHang").value = "";
    
    document.getElementById("btnHuy").addEventListener("click", function(){
        getidselect.innerHTML = "";
        document.getElementById("txtHang").value = "";
    })
}

function forbtnThem(){
    document.getElementById("btnThem").style.display = "none";
    document.getElementById("hang").style.display = "block";
    document.getElementById("btnLuu").style.display = "inline-block";
}