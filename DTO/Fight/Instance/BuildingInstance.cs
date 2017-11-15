using System;


namespace Protocol.DTO.Fight.Instance
{
    [Serializable]
    public class BuildingInstance:AbsFightInstance
    {
        public float eAngleX;
        public float eAngleY;
        public float eAngleZ;
        public float scaleX;
        public float scaleY;
        public float scaleZ;
        public BuildingModel buildingModel;

        public BuildingInstance(AbsFightModel fightModel, BuildingModel buildingModel)
        {
            this.buildingModel = buildingModel;
            this.fightModel = fightModel;
        }
    }
}
