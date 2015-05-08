﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Contracts;
using Contracts.Parameters;
using Contracts.Agents;
using Contracts.Predicates;
using Contracts.Templates;
using Contracts.Agents.Mentalities;

namespace ContractController
{
    public struct TypePreference
    {
        public int minParams;
        public int maxParams;
        public int minPrestiege;
        public int maxPrestiege;

        public float minFundsAdvance;

        public float minFundsCompletion;
        public float minScienceCompletion;
        public float minRepCompletion;

        public float minFundsFailure;
        public float minRepFailure;

        public float maxFundsAdvance;

        public float maxFundsCompletion;
        public float maxScienceCompletion;
        public float maxRepCompletion;

        public float maxFundsFailure;
        public float maxRepFailure;

        
        public List<String> blockedStrings;
        public List<String> blockedBodies;
        public List<ContractParameter> blockedParameters;
        public List<Agent> blockedAgents;
        public List<Contract.ContractPrestige> blockedPrestieges;
        public List<AgentMentality> blockedMentalities;
        

        public List<String> autoStrings;
        public List<Type> autoTypes;
        public List<String> autoBodies;
        public List<ContractParameter> autoParameters;
        public List<Agent> autoAgents;
        public List<Contract.ContractPrestige> autoPrestieges;
        public List<AgentMentality> autoMentalities;

        public static TypePreference getDefaultTypePreference()
        {
            TypePreference tp;
            tp.minParams = 1;
            tp.maxParams = 100;
            tp.minPrestiege = 0;
            tp.maxPrestiege = 3;

            tp.minFundsAdvance = 0;
            tp.maxFundsAdvance = 1000000;

            tp.minFundsCompletion = 0;
            tp.minScienceCompletion = 0;
            tp.minRepCompletion = 0;

            tp.maxFundsCompletion = 100000;
            tp.maxScienceCompletion = 10000;
            tp.maxRepCompletion = 10000;

            tp.minFundsFailure = 0;
            tp.minRepFailure = 0;

            tp.maxFundsFailure = 100000;
            tp.maxRepFailure = 10000;

            tp.blockedStrings = new List<string>();
            tp.blockedBodies = new List<string>();
            tp.blockedParameters = new List<ContractParameter>();
            tp.blockedAgents = new List<Agent>();
            tp.blockedPrestieges = new List<Contract.ContractPrestige>();
            tp.blockedMentalities = new List<AgentMentality>();

            tp.autoStrings = new List<string>();
            tp.autoTypes = new List<Type>();
            tp.autoBodies = new List<string>();
            tp.autoParameters = new List<ContractParameter>();
            tp.autoAgents = new List<Agent>();
            tp.autoPrestieges = new List<Contract.ContractPrestige>();
            tp.autoMentalities = new List<AgentMentality>();
            return tp;
        }
    }
}
