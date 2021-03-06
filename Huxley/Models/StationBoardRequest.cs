﻿/*
Huxley - a JSON proxy for the UK National Rail Live Departure Board SOAP API
Copyright (C) 2015 James Singleton
 * http://huxley.unop.uk
 * https://github.com/jpsingleton/Huxley

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU Affero General Public License as published
by the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU Affero General Public License for more details.

You should have received a copy of the GNU Affero General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

using Huxley.ldbServiceReference;

namespace Huxley.Models {
    public class StationBoardRequest : BaseRequest {
        private string crs;
        private string filterCrs;
        private ushort numRows;
        public Board Board { get; set; }
        public string Crs {
            get { return crs != null ? crs.ToUpperInvariant() : null; }
            set { crs = value; }
        }
        public FilterType FilterType { get; set; }
        public string FilterCrs {
            get { return filterCrs != null ? filterCrs.ToUpperInvariant() : null; }
            set { filterCrs = value; }
        }
        public ushort NumRows {
            get { return (ushort)(numRows > 0 ? numRows : 10); }
            set { numRows = value; }
        }
        public string Std { get; set; }
        public bool Expand { get; set; }
    }
}