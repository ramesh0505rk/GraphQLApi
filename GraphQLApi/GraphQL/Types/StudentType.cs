using GraphQLApi.Model;

namespace GraphQLApi.GraphQL.Types
{
    public class StudentType:ObjectType<Student>
    {
        protected override void Configure(IObjectTypeDescriptor<Student> descriptor)
        {
            descriptor.Field(s=>s.RollNo).Type<NonNullType<IdType>>();
            descriptor.Field(s=>s.Name).Type<NonNullType<StringType>>();
            descriptor.Field(s => s.Dept).Type<NonNullType<StringType>>();
            descriptor.Field(s => s.Cgpa).Type<NonNullType<FloatType>>();
        }
    }
}
