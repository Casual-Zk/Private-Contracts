using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Web3;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts;
using System.Threading;

namespace PrivateContracts.Contracts.SampleERC1155.ContractDefinition
{


    public partial class SampleERC1155Deployment : SampleERC1155DeploymentBase
    {
        public SampleERC1155Deployment() : base(BYTECODE) { }
        public SampleERC1155Deployment(string byteCode) : base(byteCode) { }
    }

    public class SampleERC1155DeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "60806040523480156200001157600080fd5b506040805160208101909152600081526200002c816200003e565b50620000383362000050565b62000213565b60026200004c828262000147565b5050565b600380546001600160a01b038381166001600160a01b0319831681179093556040519116919082907f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e090600090a35050565b634e487b7160e01b600052604160045260246000fd5b600181811c90821680620000cd57607f821691505b602082108103620000ee57634e487b7160e01b600052602260045260246000fd5b50919050565b601f8211156200014257600081815260208120601f850160051c810160208610156200011d5750805b601f850160051c820191505b818110156200013e5782815560010162000129565b5050505b505050565b81516001600160401b03811115620001635762000163620000a2565b6200017b81620001748454620000b8565b84620000f4565b602080601f831160018114620001b357600084156200019a5750858301515b600019600386901b1c1916600185901b1785556200013e565b600085815260208120601f198616915b82811015620001e457888601518255948401946001909101908401620001c3565b5085821015620002035787850151600019600388901b60f8161c191681555b5050505050600190811b01905550565b6118e180620002236000396000f3fe608060405234801561001057600080fd5b50600436106100e95760003560e01c8063715018a61161008c578063bd85b03911610066578063bd85b039146101f7578063e985e9c514610217578063f242432a14610253578063f2fde38b1461026657600080fd5b8063715018a6146101c15780638da5cb5b146101c9578063a22cb465146101e457600080fd5b80630e89341c116100c85780630e89341c1461014c5780632eb2c2d61461016c5780634e1273f41461017f5780634f558e791461019f57600080fd5b8062fdd58e146100ee57806301ffc9a71461011457806302fe530514610137575b600080fd5b6101016100fc366004610f26565b610279565b6040519081526020015b60405180910390f35b610127610122366004610f66565b610312565b604051901515815260200161010b565b61014a61014536600461102b565b610362565b005b61015f61015a36600461107c565b610376565b60405161010b91906110db565b61014a61017a3660046111a3565b61040a565b61019261018d36600461124d565b610456565b60405161010b9190611353565b6101276101ad36600461107c565b600090815260046020526040902054151590565b61014a610580565b6003546040516001600160a01b03909116815260200161010b565b61014a6101f2366004611366565b610594565b61010161020536600461107c565b60009081526004602052604090205490565b6101276102253660046113a2565b6001600160a01b03918216600090815260016020908152604080832093909416825291909152205460ff1690565b61014a6102613660046113d5565b6105a3565b61014a61027436600461143a565b6105e8565b60006001600160a01b0383166102e95760405162461bcd60e51b815260206004820152602a60248201527f455243313135353a2061646472657373207a65726f206973206e6f742061207660448201526930b634b21037bbb732b960b11b60648201526084015b60405180910390fd5b506000818152602081815260408083206001600160a01b03861684529091529020545b92915050565b60006001600160e01b03198216636cdb3d1360e11b148061034357506001600160e01b031982166303a24d0760e21b145b8061030c57506301ffc9a760e01b6001600160e01b031983161461030c565b61036a61065e565b610373816106b8565b50565b60606002805461038590611455565b80601f01602080910402602001604051908101604052809291908181526020018280546103b190611455565b80156103fe5780601f106103d3576101008083540402835291602001916103fe565b820191906000526020600020905b8154815290600101906020018083116103e157829003601f168201915b50505050509050919050565b6001600160a01b03851633148061042657506104268533610225565b6104425760405162461bcd60e51b81526004016102e09061148f565b61044f85858585856106c4565b5050505050565b606081518351146104bb5760405162461bcd60e51b815260206004820152602960248201527f455243313135353a206163636f756e747320616e6420696473206c656e677468604482015268040dad2e6dac2e8c6d60bb1b60648201526084016102e0565b6000835167ffffffffffffffff8111156104d7576104d7610f8a565b604051908082528060200260200182016040528015610500578160200160208202803683370190505b50905060005b84518110156105785761054b858281518110610524576105246114dd565b602002602001015185838151811061053e5761053e6114dd565b6020026020010151610279565b82828151811061055d5761055d6114dd565b602090810291909101015261057181611509565b9050610506565b509392505050565b61058861065e565b61059260006108af565b565b61059f338383610901565b5050565b6001600160a01b0385163314806105bf57506105bf8533610225565b6105db5760405162461bcd60e51b81526004016102e09061148f565b61044f85858585856109e1565b6105f061065e565b6001600160a01b0381166106555760405162461bcd60e51b815260206004820152602660248201527f4f776e61626c653a206e6577206f776e657220697320746865207a65726f206160448201526564647265737360d01b60648201526084016102e0565b610373816108af565b6003546001600160a01b031633146105925760405162461bcd60e51b815260206004820181905260248201527f4f776e61626c653a2063616c6c6572206973206e6f7420746865206f776e657260448201526064016102e0565b600261059f828261156d565b81518351146107265760405162461bcd60e51b815260206004820152602860248201527f455243313135353a2069647320616e6420616d6f756e7473206c656e677468206044820152670dad2e6dac2e8c6d60c31b60648201526084016102e0565b6001600160a01b03841661074c5760405162461bcd60e51b81526004016102e09061162d565b3361075b818787878787610b19565b60005b845181101561084157600085828151811061077b5761077b6114dd565b602002602001015190506000858381518110610799576107996114dd565b602090810291909101810151600084815280835260408082206001600160a01b038e1683529093529190912054909150818110156107e95760405162461bcd60e51b81526004016102e090611672565b6000838152602081815260408083206001600160a01b038e8116855292528083208585039055908b168252812080548492906108269084906116bc565b925050819055505050508061083a90611509565b905061075e565b50846001600160a01b0316866001600160a01b0316826001600160a01b03167f4a39dc06d4c0dbc64b70af90fd698a233a518aa5d07e595d983b8c0526c8f7fb87876040516108919291906116cf565b60405180910390a46108a7818787878787610b27565b505050505050565b600380546001600160a01b038381166001600160a01b0319831681179093556040519116919082907f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e090600090a35050565b816001600160a01b0316836001600160a01b0316036109745760405162461bcd60e51b815260206004820152602960248201527f455243313135353a2073657474696e6720617070726f76616c20737461747573604482015268103337b91039b2b63360b91b60648201526084016102e0565b6001600160a01b03838116600081815260016020908152604080832094871680845294825291829020805460ff191686151590811790915591519182527f17307eab39ab6107e8899845ad3d59bd9653f200f220920489ca2b5937696c31910160405180910390a3505050565b6001600160a01b038416610a075760405162461bcd60e51b81526004016102e09061162d565b336000610a1385610c8b565b90506000610a2085610c8b565b9050610a30838989858589610b19565b6000868152602081815260408083206001600160a01b038c16845290915290205485811015610a715760405162461bcd60e51b81526004016102e090611672565b6000878152602081815260408083206001600160a01b038d8116855292528083208985039055908a16825281208054889290610aae9084906116bc565b909155505060408051888152602081018890526001600160a01b03808b16928c821692918816917fc3d58168c5ae7397731d063d5bbf3d657854427343f4c083240f7aacaa2d0f62910160405180910390a4610b0e848a8a8a8a8a610cd6565b505050505050505050565b6108a7868686868686610d91565b6001600160a01b0384163b156108a75760405163bc197c8160e01b81526001600160a01b0385169063bc197c8190610b6b90899089908890889088906004016116fd565b6020604051808303816000875af1925050508015610ba6575060408051601f3d908101601f19168201909252610ba39181019061175b565b60015b610c5257610bb2611778565b806308c379a003610beb5750610bc6611794565b80610bd15750610bed565b8060405162461bcd60e51b81526004016102e091906110db565b505b60405162461bcd60e51b815260206004820152603460248201527f455243313135353a207472616e7366657220746f206e6f6e2d455243313135356044820152732932b1b2b4bb32b91034b6b83632b6b2b73a32b960611b60648201526084016102e0565b6001600160e01b0319811663bc197c8160e01b14610c825760405162461bcd60e51b81526004016102e09061181e565b50505050505050565b60408051600180825281830190925260609160009190602080830190803683370190505090508281600081518110610cc557610cc56114dd565b602090810291909101015292915050565b6001600160a01b0384163b156108a75760405163f23a6e6160e01b81526001600160a01b0385169063f23a6e6190610d1a9089908990889088908890600401611866565b6020604051808303816000875af1925050508015610d55575060408051601f3d908101601f19168201909252610d529181019061175b565b60015b610d6157610bb2611778565b6001600160e01b0319811663f23a6e6160e01b14610c825760405162461bcd60e51b81526004016102e09061181e565b6001600160a01b038516610e185760005b8351811015610e1657828181518110610dbd57610dbd6114dd565b602002602001015160046000868481518110610ddb57610ddb6114dd565b602002602001015181526020019081526020016000206000828254610e0091906116bc565b90915550610e0f905081611509565b9050610da2565b505b6001600160a01b0384166108a75760005b8351811015610c82576000848281518110610e4657610e466114dd565b602002602001015190506000848381518110610e6457610e646114dd565b6020026020010151905060006004600084815260200190815260200160002054905081811015610ee75760405162461bcd60e51b815260206004820152602860248201527f455243313135353a206275726e20616d6f756e74206578636565647320746f74604482015267616c537570706c7960c01b60648201526084016102e0565b60009283526004602052604090922091039055610f0381611509565b9050610e29565b80356001600160a01b0381168114610f2157600080fd5b919050565b60008060408385031215610f3957600080fd5b610f4283610f0a565b946020939093013593505050565b6001600160e01b03198116811461037357600080fd5b600060208284031215610f7857600080fd5b8135610f8381610f50565b9392505050565b634e487b7160e01b600052604160045260246000fd5b601f8201601f1916810167ffffffffffffffff81118282101715610fc657610fc6610f8a565b6040525050565b600067ffffffffffffffff831115610fe757610fe7610f8a565b604051610ffe601f8501601f191660200182610fa0565b80915083815284848401111561101357600080fd5b83836020830137600060208583010152509392505050565b60006020828403121561103d57600080fd5b813567ffffffffffffffff81111561105457600080fd5b8201601f8101841361106557600080fd5b61107484823560208401610fcd565b949350505050565b60006020828403121561108e57600080fd5b5035919050565b6000815180845260005b818110156110bb5760208185018101518683018201520161109f565b506000602082860101526020601f19601f83011685010191505092915050565b602081526000610f836020830184611095565b600067ffffffffffffffff82111561110857611108610f8a565b5060051b60200190565b600082601f83011261112357600080fd5b81356020611130826110ee565b60405161113d8282610fa0565b83815260059390931b850182019282810191508684111561115d57600080fd5b8286015b848110156111785780358352918301918301611161565b509695505050505050565b600082601f83011261119457600080fd5b610f8383833560208501610fcd565b600080600080600060a086880312156111bb57600080fd5b6111c486610f0a565b94506111d260208701610f0a565b9350604086013567ffffffffffffffff808211156111ef57600080fd5b6111fb89838a01611112565b9450606088013591508082111561121157600080fd5b61121d89838a01611112565b9350608088013591508082111561123357600080fd5b5061124088828901611183565b9150509295509295909350565b6000806040838503121561126057600080fd5b823567ffffffffffffffff8082111561127857600080fd5b818501915085601f83011261128c57600080fd5b81356020611299826110ee565b6040516112a68282610fa0565b83815260059390931b85018201928281019150898411156112c657600080fd5b948201945b838610156112eb576112dc86610f0a565b825294820194908201906112cb565b9650508601359250508082111561130157600080fd5b5061130e85828601611112565b9150509250929050565b600081518084526020808501945080840160005b838110156113485781518752958201959082019060010161132c565b509495945050505050565b602081526000610f836020830184611318565b6000806040838503121561137957600080fd5b61138283610f0a565b91506020830135801515811461139757600080fd5b809150509250929050565b600080604083850312156113b557600080fd5b6113be83610f0a565b91506113cc60208401610f0a565b90509250929050565b600080600080600060a086880312156113ed57600080fd5b6113f686610f0a565b945061140460208701610f0a565b93506040860135925060608601359150608086013567ffffffffffffffff81111561142e57600080fd5b61124088828901611183565b60006020828403121561144c57600080fd5b610f8382610f0a565b600181811c9082168061146957607f821691505b60208210810361148957634e487b7160e01b600052602260045260246000fd5b50919050565b6020808252602e908201527f455243313135353a2063616c6c6572206973206e6f7420746f6b656e206f776e60408201526d195c881bdc88185c1c1c9bdd995960921b606082015260800190565b634e487b7160e01b600052603260045260246000fd5b634e487b7160e01b600052601160045260246000fd5b60006001820161151b5761151b6114f3565b5060010190565b601f82111561156857600081815260208120601f850160051c810160208610156115495750805b601f850160051c820191505b818110156108a757828155600101611555565b505050565b815167ffffffffffffffff81111561158757611587610f8a565b61159b816115958454611455565b84611522565b602080601f8311600181146115d057600084156115b85750858301515b600019600386901b1c1916600185901b1785556108a7565b600085815260208120601f198616915b828110156115ff578886015182559484019460019091019084016115e0565b508582101561161d5787850151600019600388901b60f8161c191681555b5050505050600190811b01905550565b60208082526025908201527f455243313135353a207472616e7366657220746f20746865207a65726f206164604082015264647265737360d81b606082015260800190565b6020808252602a908201527f455243313135353a20696e73756666696369656e742062616c616e636520666f60408201526939103a3930b739b332b960b11b606082015260800190565b8082018082111561030c5761030c6114f3565b6040815260006116e26040830185611318565b82810360208401526116f48185611318565b95945050505050565b6001600160a01b0386811682528516602082015260a06040820181905260009061172990830186611318565b828103606084015261173b8186611318565b9050828103608084015261174f8185611095565b98975050505050505050565b60006020828403121561176d57600080fd5b8151610f8381610f50565b600060033d11156117915760046000803e5060005160e01c5b90565b600060443d10156117a25790565b6040516003193d81016004833e81513d67ffffffffffffffff81602484011181841117156117d257505050505090565b82850191508151818111156117ea5750505050505090565b843d87010160208285010111156118045750505050505090565b61181360208286010187610fa0565b509095945050505050565b60208082526028908201527f455243313135353a204552433131353552656365697665722072656a656374656040820152676420746f6b656e7360c01b606082015260800190565b6001600160a01b03868116825285166020820152604081018490526060810183905260a0608082018190526000906118a090830184611095565b97965050505050505056fea26469706673582212208167d872516d2e78b00af31c5041c6d012d2bff6f80716f5a4f5a697217fd70864736f6c63430008130033";
        public SampleERC1155DeploymentBase() : base(BYTECODE) { }
        public SampleERC1155DeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class BalanceOfFunction : BalanceOfFunctionBase { }

    [Function("balanceOf", "uint256")]
    public class BalanceOfFunctionBase : FunctionMessage
    {
        [Parameter("address", "account", 1)]
        public virtual string Account { get; set; }
        [Parameter("uint256", "id", 2)]
        public virtual BigInteger Id { get; set; }
    }

    public partial class BalanceOfBatchFunction : BalanceOfBatchFunctionBase { }

    [Function("balanceOfBatch", "uint256[]")]
    public class BalanceOfBatchFunctionBase : FunctionMessage
    {
        [Parameter("address[]", "accounts", 1)]
        public virtual List<string> Accounts { get; set; }
        [Parameter("uint256[]", "ids", 2)]
        public virtual List<BigInteger> Ids { get; set; }
    }

    public partial class ExistsFunction : ExistsFunctionBase { }

    [Function("exists", "bool")]
    public class ExistsFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "id", 1)]
        public virtual BigInteger Id { get; set; }
    }

    public partial class IsApprovedForAllFunction : IsApprovedForAllFunctionBase { }

    [Function("isApprovedForAll", "bool")]
    public class IsApprovedForAllFunctionBase : FunctionMessage
    {
        [Parameter("address", "account", 1)]
        public virtual string Account { get; set; }
        [Parameter("address", "operator", 2)]
        public virtual string Operator { get; set; }
    }

    public partial class OwnerFunction : OwnerFunctionBase { }

    [Function("owner", "address")]
    public class OwnerFunctionBase : FunctionMessage
    {

    }

    public partial class RenounceOwnershipFunction : RenounceOwnershipFunctionBase { }

    [Function("renounceOwnership")]
    public class RenounceOwnershipFunctionBase : FunctionMessage
    {

    }

    public partial class SafeBatchTransferFromFunction : SafeBatchTransferFromFunctionBase { }

    [Function("safeBatchTransferFrom")]
    public class SafeBatchTransferFromFunctionBase : FunctionMessage
    {
        [Parameter("address", "from", 1)]
        public virtual string From { get; set; }
        [Parameter("address", "to", 2)]
        public virtual string To { get; set; }
        [Parameter("uint256[]", "ids", 3)]
        public virtual List<BigInteger> Ids { get; set; }
        [Parameter("uint256[]", "amounts", 4)]
        public virtual List<BigInteger> Amounts { get; set; }
        [Parameter("bytes", "data", 5)]
        public virtual byte[] Data { get; set; }
    }

    public partial class SafeTransferFromFunction : SafeTransferFromFunctionBase { }

    [Function("safeTransferFrom")]
    public class SafeTransferFromFunctionBase : FunctionMessage
    {
        [Parameter("address", "from", 1)]
        public virtual string From { get; set; }
        [Parameter("address", "to", 2)]
        public virtual string To { get; set; }
        [Parameter("uint256", "id", 3)]
        public virtual BigInteger Id { get; set; }
        [Parameter("uint256", "amount", 4)]
        public virtual BigInteger Amount { get; set; }
        [Parameter("bytes", "data", 5)]
        public virtual byte[] Data { get; set; }
    }

    public partial class SetApprovalForAllFunction : SetApprovalForAllFunctionBase { }

    [Function("setApprovalForAll")]
    public class SetApprovalForAllFunctionBase : FunctionMessage
    {
        [Parameter("address", "operator", 1)]
        public virtual string Operator { get; set; }
        [Parameter("bool", "approved", 2)]
        public virtual bool Approved { get; set; }
    }

    public partial class SetURIFunction : SetURIFunctionBase { }

    [Function("setURI")]
    public class SetURIFunctionBase : FunctionMessage
    {
        [Parameter("string", "newuri", 1)]
        public virtual string Newuri { get; set; }
    }

    public partial class SupportsInterfaceFunction : SupportsInterfaceFunctionBase { }

    [Function("supportsInterface", "bool")]
    public class SupportsInterfaceFunctionBase : FunctionMessage
    {
        [Parameter("bytes4", "interfaceId", 1)]
        public virtual byte[] InterfaceId { get; set; }
    }

    public partial class TotalSupplyFunction : TotalSupplyFunctionBase { }

    [Function("totalSupply", "uint256")]
    public class TotalSupplyFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "id", 1)]
        public virtual BigInteger Id { get; set; }
    }

    public partial class TransferOwnershipFunction : TransferOwnershipFunctionBase { }

    [Function("transferOwnership")]
    public class TransferOwnershipFunctionBase : FunctionMessage
    {
        [Parameter("address", "newOwner", 1)]
        public virtual string NewOwner { get; set; }
    }

    public partial class UriFunction : UriFunctionBase { }

    [Function("uri", "string")]
    public class UriFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class ApprovalForAllEventDTO : ApprovalForAllEventDTOBase { }

    [Event("ApprovalForAll")]
    public class ApprovalForAllEventDTOBase : IEventDTO
    {
        [Parameter("address", "account", 1, true )]
        public virtual string Account { get; set; }
        [Parameter("address", "operator", 2, true )]
        public virtual string Operator { get; set; }
        [Parameter("bool", "approved", 3, false )]
        public virtual bool Approved { get; set; }
    }

    public partial class OwnershipTransferredEventDTO : OwnershipTransferredEventDTOBase { }

    [Event("OwnershipTransferred")]
    public class OwnershipTransferredEventDTOBase : IEventDTO
    {
        [Parameter("address", "previousOwner", 1, true )]
        public virtual string PreviousOwner { get; set; }
        [Parameter("address", "newOwner", 2, true )]
        public virtual string NewOwner { get; set; }
    }

    public partial class TransferBatchEventDTO : TransferBatchEventDTOBase { }

    [Event("TransferBatch")]
    public class TransferBatchEventDTOBase : IEventDTO
    {
        [Parameter("address", "operator", 1, true )]
        public virtual string Operator { get; set; }
        [Parameter("address", "from", 2, true )]
        public virtual string From { get; set; }
        [Parameter("address", "to", 3, true )]
        public virtual string To { get; set; }
        [Parameter("uint256[]", "ids", 4, false )]
        public virtual List<BigInteger> Ids { get; set; }
        [Parameter("uint256[]", "values", 5, false )]
        public virtual List<BigInteger> Values { get; set; }
    }

    public partial class TransferSingleEventDTO : TransferSingleEventDTOBase { }

    [Event("TransferSingle")]
    public class TransferSingleEventDTOBase : IEventDTO
    {
        [Parameter("address", "operator", 1, true )]
        public virtual string Operator { get; set; }
        [Parameter("address", "from", 2, true )]
        public virtual string From { get; set; }
        [Parameter("address", "to", 3, true )]
        public virtual string To { get; set; }
        [Parameter("uint256", "id", 4, false )]
        public virtual BigInteger Id { get; set; }
        [Parameter("uint256", "value", 5, false )]
        public virtual BigInteger Value { get; set; }
    }

    public partial class URIEventDTO : URIEventDTOBase { }

    [Event("URI")]
    public class URIEventDTOBase : IEventDTO
    {
        [Parameter("string", "value", 1, false )]
        public virtual string Value { get; set; }
        [Parameter("uint256", "id", 2, true )]
        public virtual BigInteger Id { get; set; }
    }

    public partial class BalanceOfOutputDTO : BalanceOfOutputDTOBase { }

    [FunctionOutput]
    public class BalanceOfOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class BalanceOfBatchOutputDTO : BalanceOfBatchOutputDTOBase { }

    [FunctionOutput]
    public class BalanceOfBatchOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256[]", "", 1)]
        public virtual List<BigInteger> ReturnValue1 { get; set; }
    }

    public partial class ExistsOutputDTO : ExistsOutputDTOBase { }

    [FunctionOutput]
    public class ExistsOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class IsApprovedForAllOutputDTO : IsApprovedForAllOutputDTOBase { }

    [FunctionOutput]
    public class IsApprovedForAllOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class OwnerOutputDTO : OwnerOutputDTOBase { }

    [FunctionOutput]
    public class OwnerOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }











    public partial class SupportsInterfaceOutputDTO : SupportsInterfaceOutputDTOBase { }

    [FunctionOutput]
    public class SupportsInterfaceOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class TotalSupplyOutputDTO : TotalSupplyOutputDTOBase { }

    [FunctionOutput]
    public class TotalSupplyOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }



    public partial class UriOutputDTO : UriOutputDTOBase { }

    [FunctionOutput]
    public class UriOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("string", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }
}
