import org.junit.experimental.categories.Categories;
import org.junit.experimental.categories.Categories.IncludeCategory;
import org.junit.runner.RunWith;
import org.junit.runners.Suite;

@RunWith(Categories.class)
@IncludeCategory(GoodTestsCategory.class)
@Suite.SuiteClasses({
	TestClassA.class
	,TestClassB.class
})
public class TestSuiteCategory {

}
