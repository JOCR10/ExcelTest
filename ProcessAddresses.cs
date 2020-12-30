using System;
using System.Collections.Generic;
using System.Text;

namespace ExcelTest
{
    public class ProcessAddresses
    {

        WideAddress _wideAddress = null;
        public ProcessAddresses(WideAddress wideAddress)
        {
            _wideAddress = wideAddress;
        }

        public List<NarrowAddress> getNarrowAddresses()
        {
            List<NarrowAddress> narrowAddresses = new List<NarrowAddress>();

            if (!string.IsNullOrEmpty(_wideAddress.Address1) && !string.IsNullOrEmpty(_wideAddress.City1) && !string.IsNullOrEmpty(_wideAddress.State1) && !string.IsNullOrEmpty(_wideAddress.Name1) && _wideAddress.Zip1 != null)
            {

                narrowAddresses.Add(new NarrowAddress
                {
                    Flag1 = _wideAddress.Flag1,
                    Flag2 = _wideAddress.Flag2,
                    Flag3 = _wideAddress.Flag3,
                    Flag4 = _wideAddress.Flag4,
                    Flag5 = _wideAddress.Flag5,
                    Name = _wideAddress.Name1,
                    Address = _wideAddress.Address1,
                    City = _wideAddress.City1,
                    State = _wideAddress.State1,
                    Zip = _wideAddress.Zip1
                });
            }
            if (!string.IsNullOrEmpty(_wideAddress.Address2) && !string.IsNullOrEmpty(_wideAddress.City2) && !string.IsNullOrEmpty(_wideAddress.State2) && !string.IsNullOrEmpty(_wideAddress.Name2) && _wideAddress.Zip2 != null)
            {

                narrowAddresses.Add(new NarrowAddress
                {
                    Flag1 = _wideAddress.Flag1,
                    Flag2 = _wideAddress.Flag2,
                    Flag3 = _wideAddress.Flag3,
                    Flag4 = _wideAddress.Flag4,
                    Flag5 = _wideAddress.Flag5,
                    Name = _wideAddress.Name2,
                    Address = _wideAddress.Address2,
                    City = _wideAddress.City2,
                    State = _wideAddress.State2,
                    Zip = _wideAddress.Zip2
                });
            }
            if (!string.IsNullOrEmpty(_wideAddress.Address3) && !string.IsNullOrEmpty(_wideAddress.City3) && !string.IsNullOrEmpty(_wideAddress.State3) && !string.IsNullOrEmpty(_wideAddress.Name3) && _wideAddress.Zip3 != null)
            {

                narrowAddresses.Add(new NarrowAddress
                {
                    Flag1 = _wideAddress.Flag1,
                    Flag2 = _wideAddress.Flag2,
                    Flag3 = _wideAddress.Flag3,
                    Flag4 = _wideAddress.Flag4,
                    Flag5 = _wideAddress.Flag5,
                    Name = _wideAddress.Name3,
                    Address = _wideAddress.Address3,
                    City = _wideAddress.City3,
                    State = _wideAddress.State3,
                    Zip = _wideAddress.Zip3
                });
            }
            if (!string.IsNullOrEmpty(_wideAddress.Address4) && !string.IsNullOrEmpty(_wideAddress.City4) && !string.IsNullOrEmpty(_wideAddress.State4) && !string.IsNullOrEmpty(_wideAddress.Name4) && _wideAddress.Zip4 != null)
            {

                narrowAddresses.Add(new NarrowAddress
                {
                    Flag1 = _wideAddress.Flag1,
                    Flag2 = _wideAddress.Flag2,
                    Flag3 = _wideAddress.Flag3,
                    Flag4 = _wideAddress.Flag4,
                    Flag5 = _wideAddress.Flag5,
                    Name = _wideAddress.Name4,
                    Address = _wideAddress.Address4,
                    City = _wideAddress.City4,
                    State = _wideAddress.State4,
                    Zip = _wideAddress.Zip4
                });
            }
            return narrowAddresses;
        }
    }
}
