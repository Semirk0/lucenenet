﻿using System.Collections.Generic;
using WeightedFragInfo = Lucene.Net.Search.VectorHighlight.FieldFragList.WeightedFragInfo;

namespace Lucene.Net.Search.VectorHighlight
{
    /*
	 * Licensed to the Apache Software Foundation (ASF) under one or more
	 * contributor license agreements.  See the NOTICE file distributed with
	 * this work for additional information regarding copyright ownership.
	 * The ASF licenses this file to You under the Apache License, Version 2.0
	 * (the "License"); you may not use this file except in compliance with
	 * the License.  You may obtain a copy of the License at
	 *
	 *     http://www.apache.org/licenses/LICENSE-2.0
	 *
	 * Unless required by applicable law or agreed to in writing, software
	 * distributed under the License is distributed on an "AS IS" BASIS,
	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
	 * See the License for the specific language governing permissions and
	 * limitations under the License.
	 */

    /// <summary>
    /// A simple implementation of FragmentsBuilder.
    /// </summary>
    public class SimpleFragmentsBuilder : BaseFragmentsBuilder
    {
        /**
   * a constructor.
   */
        public SimpleFragmentsBuilder()
            : base()
        {
        }

        /**
         * a constructor.
         * 
         * @param preTags array of pre-tags for markup terms.
         * @param postTags array of post-tags for markup terms.
         */
        public SimpleFragmentsBuilder(string[] preTags, string[] postTags)
            : base(preTags, postTags)
        {
        }

        public SimpleFragmentsBuilder(IBoundaryScanner bs)
            : base(bs)
        {
        }

        public SimpleFragmentsBuilder(string[] preTags, string[] postTags, IBoundaryScanner bs)
            : base(preTags, postTags, bs)
        {
        }

        /**
         * do nothing. return the source list.
         */
        public override IList<WeightedFragInfo> GetWeightedFragInfoList(IList<WeightedFragInfo> src)
        {
            return src;
        }
    }
}