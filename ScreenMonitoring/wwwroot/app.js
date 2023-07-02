async function getCpuUsageInPercent() {
    cpuUsage.innerText = "...";
    const response = await fetch("/api/cpu").then(response => {
        if (response.ok) {
            response.json().then(data => {
                let respInString = JSON.stringify(data);
                let respInObj = JSON.parse(respInString);
                cpuUsage.innerText = respInObj["rcpuUsageInPecent"] + " %";
            })
        }
        else
            cpuUsage.innerText = "empty";
    });
}


async function getRamUsageInGB() {
    ramUsage.innerText = "...";
    const response = await fetch("/api/ram").then(response => {
        if (response.ok) {
            response.json().then(data => {
                let respInString = JSON.stringify(data);
                let respInObj = JSON.parse(respInString);
                ramUsage.innerText = respInObj["ramUsageInGB"] + " GB";
            })
        }
        else
            ramUsage.innerText = "empty";
    });
}


async function getDiskAvailableInGB() {
    diskAvailable.innerText = "...";
    const response = await fetch("/api/disk").then(response => {
        if (response.ok) {
            response.json().then(data => {
                let respInString = JSON.stringify(data);
                let respInObj = JSON.parse(respInString);
                diskAvailable.innerText = respInObj["diskAvailableInGB"] + " GB";
            })
        }
        else
            diskAvailable.innerText = "empty";
    });
}

const buttonGetCpu = document.getElementById("btnCpu");
const cpuUsage = document.querySelector("#usageCPU");

const buttonGetRam = document.getElementById("btnRam");
const ramUsage = document.querySelector("#usageRAM");

const buttonGetDisk = document.getElementById("btnDisk");
const diskAvailable = document.getElementById("usageDisk");

buttonGetCpu.addEventListener('click', getCpuUsageInPercent);
buttonGetRam.addEventListener('click', getRamUsageInGB);
buttonGetDisk.addEventListener('click', getDiskAvailableInGB);