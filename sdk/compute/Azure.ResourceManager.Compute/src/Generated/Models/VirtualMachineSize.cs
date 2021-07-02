// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes the properties of a VM size. </summary>
    public partial class VirtualMachineSize
    {
        /// <summary> Initializes a new instance of VirtualMachineSize. </summary>
        internal VirtualMachineSize()
        {
        }

        /// <summary> Initializes a new instance of VirtualMachineSize. </summary>
        /// <param name="name"> The name of the virtual machine size. </param>
        /// <param name="numberOfCores"> The number of cores supported by the virtual machine size. For Constrained vCPU capable VM sizes, this number represents the total vCPUs of quota that the VM uses. For accurate vCPU count, please refer to https://docs.microsoft.com/azure/virtual-machines/constrained-vcpu or https://docs.microsoft.com/rest/api/compute/resourceskus/list. </param>
        /// <param name="osDiskSizeInMB"> The OS disk size, in MB, allowed by the virtual machine size. </param>
        /// <param name="resourceDiskSizeInMB"> The resource disk size, in MB, allowed by the virtual machine size. </param>
        /// <param name="memoryInMB"> The amount of memory, in MB, supported by the virtual machine size. </param>
        /// <param name="maxDataDiskCount"> The maximum number of data disks that can be attached to the virtual machine size. </param>
        internal VirtualMachineSize(string name, int? numberOfCores, int? osDiskSizeInMB, int? resourceDiskSizeInMB, int? memoryInMB, int? maxDataDiskCount)
        {
            Name = name;
            NumberOfCores = numberOfCores;
            OsDiskSizeInMB = osDiskSizeInMB;
            ResourceDiskSizeInMB = resourceDiskSizeInMB;
            MemoryInMB = memoryInMB;
            MaxDataDiskCount = maxDataDiskCount;
        }

        /// <summary> The name of the virtual machine size. </summary>
        public string Name { get; }
        /// <summary> The number of cores supported by the virtual machine size. For Constrained vCPU capable VM sizes, this number represents the total vCPUs of quota that the VM uses. For accurate vCPU count, please refer to https://docs.microsoft.com/azure/virtual-machines/constrained-vcpu or https://docs.microsoft.com/rest/api/compute/resourceskus/list. </summary>
        public int? NumberOfCores { get; }
        /// <summary> The OS disk size, in MB, allowed by the virtual machine size. </summary>
        public int? OsDiskSizeInMB { get; }
        /// <summary> The resource disk size, in MB, allowed by the virtual machine size. </summary>
        public int? ResourceDiskSizeInMB { get; }
        /// <summary> The amount of memory, in MB, supported by the virtual machine size. </summary>
        public int? MemoryInMB { get; }
        /// <summary> The maximum number of data disks that can be attached to the virtual machine size. </summary>
        public int? MaxDataDiskCount { get; }
    }
}
